#r "C:\\Users\\Dawson\\.nuget\\packages\\fsharp.data\\3.3.3\\lib\\netstandard2.0\\FSharp.Data.dll"
open FSharp.Data
open FSharp.Data.HttpRequestHeaders
open FSharp.Data.JsonExtensions

let apiKey = "1a290642d2b64f4087db2cf3752b1090"
let url = "https://api.cognitive.microsofttranslator.com/translate"

// Run the HTTP web request
let response = Http.RequestString ( url, 
    body = TextRequest "[{'Text':'Hello, what is your name?'}]",
    query = [ "api-version", "3.0"; "to", "es"; "to", "de" ],
    headers = [ Accept HttpContentTypes.Json; 
        ContentType HttpContentTypes.Json;
        "Ocp-Apim-Subscription-Key", apiKey; ] ) |> JsonValue.Parse

//response.value?translations

[ for v in response -> v?translations] 
|> Seq.collect (fun translations -> [for t in translations -> t?text])
|> Seq.toList
