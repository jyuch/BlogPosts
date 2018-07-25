namespace CommandLine.Parser

open System

type Param = { Level:int; IsDryRun:bool; OutputName:string option; Files:string list }

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Param = 
    
    let rec parseImpl input param =
            match input with
            | "--level" :: x :: tail ->
                match Int32.TryParse(x) with
                | (true, x) when 1 <= x && x <= 5 -> parseImpl tail { param with Level = x }
                | _ -> parseImpl tail param
            | "--dry-run" :: tail -> 
                parseImpl tail { param with IsDryRun = true }
            | "--output-name" :: name :: tail ->
                parseImpl tail { param with OutputName = Some(name) }
            | head :: tail ->
                parseImpl tail { param with Files = head :: param.Files }
            | [] -> param

    [<CompiledName("Parse")>]
    let parse input =
        parseImpl (Array.toList input) { Level = 1; IsDryRun = false; OutputName = None; Files = [] } 

    [<CompiledName("Show")>]
    let show x = printfn "%A" x