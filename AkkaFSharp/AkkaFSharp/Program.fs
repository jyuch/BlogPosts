open System
open Akka
open Akka.FSharp
open Akka.Actor

(* アクターシステムを生成 *)
let system = System.create "fsharp" <| Configuration.load ()

(* アクター間でやり取りを行うメッセージを定義 *)
type Value =
    | Value of value: int

(* メッセージを受け取ってコンソールに出力するアクターの定義 *)
let printToConsole (mailbox: Actor<_>) =
    let rec loop ()  = actor {
        let! Value(value) = mailbox.Receive ()  
        printfn "Value is %A" value
        return! loop ()
    }
    loop ()

(* 述語を満たすメッセージのみを次のアクターに渡すアクターの定義 *)
let filter (predicate: 'a -> bool) (next: IActorRef) (mailbox: Actor<_>) =
    let rec loop () = actor {
        let! message = mailbox.Receive ()
        if predicate(message) then
            next <! message
        return! loop ()
    }
    loop ()

(* 指定されたコンバータを適用して次のアクターに渡すアクターの定義 *)
let convert (converter: 'a -> 'a) (next: IActorRef) (mailbox: Actor<_>) =
    let rec loop () = actor {
        let! message = mailbox.Receive ()
        next <! (converter <| message)
        return! loop ()
    }
    loop ()

[<EntryPoint>]
let main argv =
    
    (* アクターの生成 *)
    let printToConsole = spawn system "printToConsole" printToConsole

    let twice (value: Value) =
        match value with
        | Value(v) ->  Value(v * 2)

    let converter = spawn system "converter" (convert <| twice <| printToConsole)

    let pred42 (value: Value) =
        match value with
        | Value(42) -> true
        | _ -> false

    let filter42 = spawn system "filter42" (filter <| pred42 <| converter)

    (* アクターにメッセージを送信 *)
    filter42 <! Value(42)
    filter42 <! Value(43)
    
    (* アクターシステムを停止 *)
    system.Terminate().Wait()
    0
