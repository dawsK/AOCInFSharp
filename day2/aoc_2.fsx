open System

type OpCode = private OpCode of int

module OpCode = 
  
  let isOpCode (c:int)= 
    match c with 
      | 1 | 2 | 99 -> true 
      |_ -> false
   
  let create (code:int) =
    if (isOpCode code) then
      Some (OpCode code)
    else 
      None

  let value (OpCode code) = code

let readLines filePath = System.IO.File.ReadLines(filePath)
let writeResult filePath (result) = System.IO.File.WriteAllText(filePath, string result)
let writeOpCode filePath (result:int) : unit = System.IO.File.WriteAllText(filePath, string result)

let restoreProgramState input = input
let getProgramResult input = input
let splitLine = (fun (line:string) -> Seq.toArray (line.Split ',') )
readLines "day2/aoc_input_2.txt"

|> Seq.collect splitLine
|> restoreProgramState
|> getProgramResult
|> Seq.head |> int
|> OpCode.create 
|> (fun op -> 
match op with 
  | Some o -> writeOpCode  "day2/aoc_output_2.txt" (OpCode.value o) //Option.fold (fun _ o -> OpCode.value o) -1
  | None -> ())

 
