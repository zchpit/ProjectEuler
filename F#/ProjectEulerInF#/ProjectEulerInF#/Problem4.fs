

namespace Application
open System

type Problem4() = "Problem4"


let isPalindrome (s: string) =
   let arr = s.ToCharArray()
   arr = Array.rev arr

let min3digit = 111
let max3digit = 999
let minValue = min3digit * min3digit;
let maxValue = max3digit * max3digit;

let palidrome = isPalindrome "aba"
let notPalidrome = isPalindrome "nie"

let solution = [ minValue .. maxValue ] |> List.map string |>  List.filter(fun x -> isPalindrome x) |> List.map int |> List.max
