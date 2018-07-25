using Sigil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.BindingFlags;

namespace SigilCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new Target()
            {
                Id = 1,
                Name = "あああああ",
                Hoge = DateTime.Now
            };

            var d = BuildDelegate(typeof(Target));
            Console.WriteLine();
            Console.WriteLine(d(target));
        }

        static Func<object, string> BuildDelegate(Type targetType)
        {
            var targetProperties = targetType.GetMembers(Public | Instance)
                .Where(it => it is PropertyInfo)
                .Select(it => (PropertyInfo)it)
                .Where(it => it.CanRead && it.GetIndexParameters().Length == 0);

            var e = Emit<Func<object, string>>.NewDynamicMethod();

            using (var target = e.DeclareLocal(targetType))
            using (var builder = e.DeclareLocal<StringBuilder>())
            {
                // target = (Target)value;
                e.LoadArgument(0);
                e.CastClass(targetType);
                e.StoreLocal(target);

                // builder = new StringBuilder();
                e.NewObject<StringBuilder>();
                e.StoreLocal(builder);

                // builder.Append(nameof(Target) + ":{")
                e.LoadLocal(builder);
                e.LoadConstant(targetType.Name + "{");
                e.CallVirtual(GetAppend(typeof(string)));

                var isNotFirst = false;
                foreach (var it in targetProperties)
                {
                    if (isNotFirst)
                    {
                        // builder.Append(",")
                        e.LoadConstant(",");
                        e.CallVirtual(GetAppend(typeof(string)));
                    }
                    isNotFirst = true;

                    // builder.Append(nameof(Target.Property) + "=")
                    e.LoadConstant(it.Name + "=");
                    e.CallVirtual(GetAppend(typeof(string)));

                    // builder.Append(target.Property)
                    e.LoadLocal(target);
                    e.CallVirtual(it.GetGetMethod());
                    if (it.PropertyType.IsValueType && !IsSupportedType(it.PropertyType))
                        e.Box(it.PropertyType);
                    e.CallVirtual(GetAppend(it.PropertyType));
                }

                // // builder.Append("}")
                e.LoadConstant("}");
                e.CallVirtual(GetAppend(typeof(string)));

                // return builder.ToString()
                var toString = typeof(object).GetMethod("ToString");
                e.CallVirtual(toString);
                e.Return();
            }

            Console.WriteLine($".maxstack {e.MaxStackSize}");
            Console.WriteLine(e.Instructions());

            return e.CreateDelegate();
        }

        static MethodInfo GetAppend(Type type)
        {
            var appends = typeof(StringBuilder)
                .GetMethods(Public | Instance)
                .Where(it => it.Name == "Append")
                .Where(it => it.GetParameters().Length == 1)
                .ToDictionary(it => it.GetParameters()[0].ParameterType);

            if (appends.ContainsKey(type))
                return appends[type];
            else
                return appends[typeof(object)];
        }

        static bool IsSupportedType(Type type)
        {
            var appends = typeof(StringBuilder)
                .GetMethods(Public | Instance)
                .Where(it => it.Name == "Append")
                .Where(it => it.GetParameters().Length == 1)
                .ToDictionary(it => it.GetParameters()[0].ParameterType);

            return appends.ContainsKey(type);
        }
    }
}
