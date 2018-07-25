using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace ToStringBuilderGenerator
{
    public sealed class ToStringBuilderGenerator
    {
        private class ReadOnlyDictionary<TKey, TValue>
        {
            private readonly Dictionary<TKey, TValue> _dict;
            public ReadOnlyDictionary(Dictionary<TKey, TValue> dict) { _dict = dict; }
            public TValue this[TKey key] { get { return _dict[key]; } }
            public bool ContainsKey(TKey key) { return _dict.ContainsKey(key); }
        }

        private static readonly ReadOnlyDictionary<Type, MethodInfo> _appends;

        static ToStringBuilderGenerator()
        {
            _appends = new ReadOnlyDictionary<Type, MethodInfo>(
                typeof(StringBuilder)
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(it => it.Name == "Append")
                .Where(it => it.GetParameters().Length == 1)
                .ToDictionary(it => it.GetParameters()[0].ParameterType));
        }

        private static bool IsSupportedType(Type type) { return _appends.ContainsKey(type); }

        private static MethodInfo GetAppend(Type type) { return _appends.ContainsKey(type) ? _appends[type] : _appends[typeof(object)]; }

        public static Func<T, string> GenerateToStringBuilder<T>()
        {
            var targetProperties = typeof(T)
                .GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .OfType<PropertyInfo>()
                .Where(it => it.CanRead && it.GetIndexParameters().Length == 0);

            var toString = new DynamicMethod("ToString" + typeof(T).GetHashCode(), typeof(string), new[] { typeof(T) }, typeof(T).Module, true);
            var il = toString.GetILGenerator();
            var ctor = typeof(StringBuilder).GetConstructor(Type.EmptyTypes);

            il.DeclareLocal(typeof(T));
            il.DeclareLocal(typeof(StringBuilder));
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Stloc_0);
            il.Emit(OpCodes.Newobj, ctor);
            il.Emit(OpCodes.Stloc_1);

            il.Emit(OpCodes.Ldloc_1);
            il.Emit(OpCodes.Ldstr, typeof(T).Name + "{");
            il.Emit(OpCodes.Callvirt, GetAppend(typeof(string)));

            var isNotFirst = false;
            foreach (var it in targetProperties)
            {
                if (isNotFirst)
                {
                    il.Emit(OpCodes.Ldstr, ",");
                    il.Emit(OpCodes.Callvirt, GetAppend(typeof(string)));
                }
                isNotFirst = true;

                il.Emit(OpCodes.Ldstr, it.Name + "=");
                il.Emit(OpCodes.Callvirt, GetAppend(typeof(string)));

                if(typeof(T).IsValueType)
                    il.Emit(OpCodes.Ldloca_S, 0);
                else
                    il.Emit(OpCodes.Ldloc_0);

                il.Emit(OpCodes.Callvirt, it.GetGetMethod());
                if (it.PropertyType.IsValueType && !IsSupportedType(it.PropertyType))
                    il.Emit(OpCodes.Box, it.PropertyType);
                il.Emit(OpCodes.Callvirt, GetAppend(it.PropertyType));
            }

            il.Emit(OpCodes.Ldstr, "}");
            il.Emit(OpCodes.Callvirt, GetAppend(typeof(string)));

            il.Emit(OpCodes.Callvirt, typeof(object).GetMethod("ToString"));
            il.Emit(OpCodes.Ret);

            return (Func<T, string>)toString.CreateDelegate(typeof(Func<T, string>));
        }
    }
}
