Imports Mono.Cecil
Imports Mono.Cecil.Cil

Module Program

    Sub Main(args As String())
        Dim assmPath = args(0)
        Dim limitDate = DateTime.Parse(args(1))

        Console.WriteLine($"Target:{assmPath}")
        Console.WriteLine($"Limit:{limitDate:yyyy/MM/dd}")

        Inject(assmPath, limitDate.Year, limitDate.Month, limitDate.Day)
    End Sub

    Sub Inject(path As String, year As Integer, month As Integer, day As Integer)
        Dim assm = AssemblyDefinition.ReadAssembly(path)
        Dim nowPropertyGetter = assm.MainModule.Import(GetType(DateTime).GetProperty("Now").GetGetMethod())
        Dim ctor = assm.MainModule.Import(GetType(DateTime).GetConstructor(New Type() {GetType(Integer), GetType(Integer), GetType(Integer)}))
        Dim graterThan = assm.MainModule.Import(GetType(DateTime).GetMethod("op_GreaterThan", New Type() {GetType(DateTime), GetType(DateTime)}))
        Dim envExit = assm.MainModule.Import(GetType(Environment).GetMethod("Exit", New Type() {GetType(Integer)}))

        Dim entryPoint = assm.EntryPoint
        Dim processor = entryPoint.Body.GetILProcessor()
        Dim first = entryPoint.Body.Instructions(0)

        processor.InsertBefore(first, processor.Create(OpCodes.Call, nowPropertyGetter))
        processor.InsertBefore(first, processor.Create(OpCodes.Ldc_I4, year))
        processor.InsertBefore(first, processor.Create(OpCodes.Ldc_I4, month))
        processor.InsertBefore(first, processor.Create(OpCodes.Ldc_I4, day))
        processor.InsertBefore(first, processor.Create(OpCodes.Newobj, ctor))
        processor.InsertBefore(first, processor.Create(OpCodes.Call, graterThan))
        processor.InsertBefore(first, processor.Create(OpCodes.Brfalse_S, first))
        processor.InsertBefore(first, processor.Create(OpCodes.Ldc_I4_0))
        processor.InsertBefore(first, processor.Create(OpCodes.Call, envExit))

        assm.Write(path)
    End Sub

End Module
