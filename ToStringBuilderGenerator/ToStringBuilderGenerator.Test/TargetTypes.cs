namespace ToStringBuilderGenerator.Test
{
    class SingleStringClass
    {
        public string Item1 { set; get; }
    }

    struct SingleStringStructre
    {
        public string Item1 { set; get; }
    }

    class SingleIntegerClass
    {
        public int Item1 { set; get; }
    }

    struct SingleIntegerStructre
    {
        public int Item1 { set; get; }
    }

    class ComplexClassType
    {
        public override string ToString()
        {
            return nameof(ComplexClassType);
        }
    }

    class SingleComplexClassTypeClass
    {
        public ComplexClassType Item1 { set; get; }  = new ComplexClassType();
    }

    struct SingleComplexClassTypeStructre
    {
        public ComplexClassType Item1 { set; get; }

        public void SingleComplexStructure()
        {
            Item1 = new ComplexClassType();
        }

    }

    struct ComplexStructureType
    {
        public override string ToString()
        {
            return nameof(ComplexStructureType);
        }
    }

    class SingleComplexStructureTypeClass
    {
        public ComplexStructureType Item1 { set; get; } = new ComplexStructureType();
    }

    struct SingleComplexStructureTypeStructre
    {
        public ComplexStructureType Item1 { set; get; }

        public void SingleComplexStructure()
        {
            Item1 = new ComplexStructureType();
        }

    }

    class ComplexClass
    {
        public int Item1 { set; get; }
        public  string Item2 { set; get; }
        public ComplexClassType Item3 { set; get; }
        public ComplexStructureType Item4 { set; get; }
    }

    struct ComplexStructure
    {
        public int Item1 { set; get; }
        public string Item2 { set; get; }
        public ComplexClassType Item3 { set; get; }
        public ComplexStructureType Item4 { set; get; }
    }
}
