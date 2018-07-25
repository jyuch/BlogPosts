using System;
using System.Text;

namespace Samplejunk
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

            Console.WriteLine(ToString(target));
        }

        static string ToString(object value)
        {
            var target = (Target)value;
            var builder = new StringBuilder();

            builder
                .Append(nameof(Target) + ":{")
                .Append(nameof(Target.Id) + "=")
                .Append(target.Id)
                .Append(",")
                .Append(nameof(Target.Name) + "=")
                .Append(target.Name)
                .Append(",")
                .Append(nameof(Target.Hoge) + "=")
                .Append(target.Hoge)
                .Append("}");

            return builder.ToString();
        }
    }

    class Target
    {
        public int Id { set; get; }
        public virtual string Name { set; get; }
        public DateTime Hoge { set; get; }
    }
}
