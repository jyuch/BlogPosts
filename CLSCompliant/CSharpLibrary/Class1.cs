using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpLibrary
{
	public class Class1
	{
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public extern int Square(int number);

        [CLSCompliant(false)]
        public uint add(uint x, uint y)
        {
            Console.WriteLine("add");
            return x + y;
        }

        [CLSCompliant(false)]
        public uint ADD(uint x, uint y)
        {
            Console.WriteLine("ADD");
            return x + y;
        }
	}
}
