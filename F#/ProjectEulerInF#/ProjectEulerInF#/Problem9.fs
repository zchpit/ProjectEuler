namespace Application
open System

let filterWithSet set lst = lst |> List.filter (fun (_, elem) -> Set.contains elem set)

let xList = [ for i in 1 .. 1000 -> i*i ] |> List.distinct
let yList = [ for i in 1 .. 1000 -> i,i*i ] |> List.distinct
let zList = xList |> List.collect (fun x -> xList |> List.map (fun y -> x + y)) |> List.distinct |> List.sort
let xxList = xList |> List.map (fun x -> xList |> List.map (fun y -> x + y),x) |> List.distinct


let filter = set xList
let cont = zList |> List.filter (fun a -> Set.contains a filter) |> List.distinct |> Set.ofList

let toAddList = filterWithSet cont yList //|> List.filter(fun (a,b)-> b = 1000000) |> List.map(fun(a,b) -> a)

//let sol1 = xxList |> List.filter(fun (a,b) -> b = 1000) |> List.map(fun(a,b) -> b)