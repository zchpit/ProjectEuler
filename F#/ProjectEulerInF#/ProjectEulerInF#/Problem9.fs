namespace Application
open System

let xList = [ for i in 1 .. 1000 -> i*i ]
let yList = [ for i in 1 .. 1000 -> i*i ]

let zList = xList |> List.collect (fun x -> yList |> List.map (fun y -> x + y))

let filter = set xList
let cont = zList |> List.filter (fun a -> Set.contains a filter) |> List.distinct

