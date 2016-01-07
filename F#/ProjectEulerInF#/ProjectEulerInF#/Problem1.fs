namespace ProjectEulerInF
open System

module Problem1 = let solution = [0 .. 999] |> List.filter(fun x -> (x % 3 = 0 || x % 5 = 0)) |> List.sum
