.assembly helloworld{}

.method public static void main() {
    .entrypoint
    .maxstack 1
    ldstr "Hello World"
    call void [mscorlib]System.Console::WriteLine(string)
    ret
}
