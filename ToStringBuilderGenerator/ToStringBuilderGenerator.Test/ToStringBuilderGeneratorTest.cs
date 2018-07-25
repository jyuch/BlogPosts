using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToStringBuilderGenerator.Test
{
    [TestClass]
    public class ToStringBuilderGeneratorTest
    {
        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleStringClass()
        {
            var target = new SingleStringClass() { Item1 = "Hoge" };
            var expected = $"{nameof(SingleStringClass)}{{{nameof(SingleStringClass.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleStringClass>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleStringStructre()
        {
            var target = new SingleStringStructre() { Item1 = "Hoge" };
            var expected = $"{nameof(SingleStringStructre)}{{{nameof(SingleStringStructre.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleStringStructre>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleIntegerClass()
        {
            var target = new SingleIntegerClass() { Item1 = 42 };
            var expected = $"{nameof(SingleIntegerClass)}{{{nameof(SingleIntegerClass.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleIntegerClass>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleIntegerStructre()
        {
            var target = new SingleIntegerStructre() { Item1 = 42 };
            var expected = $"{nameof(SingleIntegerStructre)}{{{nameof(SingleIntegerStructre.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleIntegerStructre>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleComplexClassTypeClass()
        {
            var target = new SingleComplexClassTypeClass();
            var expected = $"{nameof(SingleComplexClassTypeClass)}{{{nameof(SingleComplexClassTypeClass.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleComplexClassTypeClass>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleComplexClassTypeStructre()
        {
            var target = new SingleComplexClassTypeStructre();
            var expected = $"{nameof(SingleComplexClassTypeStructre)}{{{nameof(SingleComplexClassTypeStructre.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleComplexClassTypeStructre>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleComplexStructureTypeClass()
        {
            var target = new SingleComplexStructureTypeClass();
            var expected = $"{nameof(SingleComplexStructureTypeClass)}{{{nameof(SingleComplexStructureTypeClass.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleComplexStructureTypeClass>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_SingleComplexStructureTypeStructre()
        {
            var target = new SingleComplexStructureTypeStructre();
            var expected = $"{nameof(SingleComplexStructureTypeStructre)}{{{nameof(SingleComplexStructureTypeStructre.Item1)}={target.Item1}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<SingleComplexStructureTypeStructre>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_ComplexClass()
        {
            var target = new ComplexClass() { Item1 = 42, Item2 = "Hoge", Item3 = new ComplexClassType(), Item4 = new ComplexStructureType() };
            var expected = $"{nameof(ComplexClass)}{{" 
                + $"{nameof(ComplexClass.Item1)}={target.Item1}," 
                + $"{nameof(ComplexClass.Item2)}={target.Item2}," 
                + $"{nameof(ComplexClass.Item3)}={target.Item3}," 
                + $"{nameof(ComplexClass.Item4)}={target.Item4}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<ComplexClass>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringBuilder_return_value_when_pass_ComplexStructure()
        {
            var target = new ComplexStructure() { Item1 = 42, Item2 = "Hoge", Item3 = new ComplexClassType(), Item4 = new ComplexStructureType() };
            var expected = $"{nameof(ComplexStructure)}{{"
                + $"{nameof(ComplexStructure.Item1)}={target.Item1},"
                + $"{nameof(ComplexStructure.Item2)}={target.Item2},"
                + $"{nameof(ComplexStructure.Item3)}={target.Item3},"
                + $"{nameof(ComplexStructure.Item4)}={target.Item4}}}";
            var builder = ToStringBuilderGenerator.GenerateToStringBuilder<ComplexStructure>();
            var actual = builder(target);

            Assert.AreEqual(expected, actual);
        }
    }
}
