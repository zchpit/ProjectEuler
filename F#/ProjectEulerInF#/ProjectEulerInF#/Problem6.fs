

namespace Application
open System

type Problem6() = type T = X


let sum1 = [for i in 1 .. 100 -> i*i] |> List.sum
let sum21 = [1 .. 100 ] |> List.sum
let sum2 = sum21 * sum21

let difference = sum2 - sum1