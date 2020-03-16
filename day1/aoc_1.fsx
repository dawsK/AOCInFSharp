open System

type Mass = Mass of int

type FuelRequired = FuelRequired of int

let getFuelRequired (Mass mass): FuelRequired = FuelRequired((mass / 3) - 2)
let getFuelInt (FuelRequired f) = f
let readLines filePath = System.IO.File.ReadLines(filePath)

let getFuelFromMass =
    (int
     >> Mass
     >> getFuelRequired
     >> getFuelInt)

let writeResult filePath (result) = System.IO.File.WriteAllText(filePath, string result)

readLines "aoc_input_1.txt"
|> Seq.sumBy getFuelFromMass
|> writeResult "aoc_output_1.txt"
