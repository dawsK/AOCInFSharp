open System

type Shape =
    | Rectangle of width : float * length : float
    | Circle of radius : float
    | Prism of width : float * float * height : float

type OpCode = 
   private 
   | ADD of int
   | MULT of int
   | HALT of int
   
type Position = Position of int
type ProgramValue = ProgramValue of int

type ProgramCode =
  | OpCode
  | Position
  | ProgramValue

module OpCode = 
  
  let isOpCode (c:int)= 
    match c with 
      | 1 | 2 | 99 -> true 
      |_ -> false
   
  let create (code:int) =
    match code with
      | 1 -> Ok (ADD code)
      | 2 -> Ok (MULT code)
      | 99 -> Ok (HALT code)
      | _ -> Error (sprintf "unknown OpCode %i" code)

  let value code = 
    match code with
    | ADD code -> 1
    | MULT code -> 2
    | HALT code -> 99
  

let readLines filePath = System.IO.File.ReadLines(filePath)
let writeResult filePath (result) = System.IO.File.WriteAllText(filePath, string result)
let writeOpCode filePath (result:int) : unit = System.IO.File.WriteAllText(filePath, string result)

let stringToProgramCode = int >> OpCode.create
let restoreProgramState (input:int list) = 
  match input with
  | [] -> input
  | opCode::_::_::rest -> opCode::12::2::rest
  | _ -> input

let getProgramResult input = input
let splitLine (line:string) = 
  line.Split ',' 
  |> Seq.map int

// Program starts
readLines "day2/aoc_input_2.txt"
|> Seq.collect splitLine |> Seq.toList
|> restoreProgramState
|> getProgramResult
|> Seq.head
|> (fun op -> 
match op with 
  | Some o -> writeOpCode  "day2/aoc_output_2.txt" (OpCode.value o) //Option.fold (fun _ o -> OpCode.value o) -1
  | None -> ())


