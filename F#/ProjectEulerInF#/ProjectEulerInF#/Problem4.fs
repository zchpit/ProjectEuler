

namespace Application
open System

type Problem4() = "Problem4"


let isPalindrome (s: string) =
   let arr = s.ToCharArray()
   arr = Array.rev arr

let palidrome = isPalindrome "aba"
let notPalidrome = isPalindrome "nie"

let min3digit = 111
let max3digit = 999

let xList = [ 111 .. 999 ]
let yList = [ 111 .. 999 ]

let list = xList |> List.collect (fun x -> yList |> List.map (fun y -> x * y))

let solution = list |> List.map string |>  List.filter(fun x -> isPalindrome x) |> List.map int |> List.max
