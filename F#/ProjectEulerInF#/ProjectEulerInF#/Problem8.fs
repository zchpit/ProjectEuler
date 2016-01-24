namespace Application
open System




let multiply list =
   let rec loop list acc =
       match list with
       | head :: tail -> loop tail (acc * head)
       | [] -> acc
   loop list 1.0
 
let list1 = [1.0 .. 3.0]
let test = multiply list1


let string = "73167176531330624919225119674426574742355349194934"
let num2 = string |> Seq.take 5 |> Seq.map Char.GetNumericValue |> Seq.toList
let test1 = multiply num2

