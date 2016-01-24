namespace Application
open System

let filterWithSet set lst = lst |> List.filter (fun (_, elem) -> Set.contains elem set)

let xList = [ for i in 1 .. 1000 -> i*i ]
let yList = [ for i in 1 .. 1000 -> i,i*i ]
let zList = xList |> List.collect (fun x -> xList |> List.map (fun y -> x + y))

let filter = set xList
let cont = zList |> List.filter (fun a -> Set.contains a filter) |> List.distinct |> Set.ofList

let abc = filterWithSet cont yList