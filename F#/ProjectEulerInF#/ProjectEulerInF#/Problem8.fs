namespace Application
open System

module Problem8 = type T = X

let string = "73167176531330624919225119674426574742355349194934"

let multiply list =
   let rec loop list acc =
       match list with
       | head :: tail -> loop tail (acc * head)
       | [] -> acc
   loop list 1.0

let num2 = string |> Seq.skip 5 |> Seq.take 5 |> Seq.map Char.GetNumericValue |> Seq.toList
let test1 = multiply num2

let rec getMaxSeq (strAll:string, minNum:int, takeNum:int, accMax:float) =
    let current = strAll |> Seq.skip minNum |> Seq.take takeNum |> Seq.map Char.GetNumericValue |> Seq.toList
    let currentVal = multiply current
    if minNum > 20 then accMax
    else
       if
          currentVal > accMax then
          accMax = currentVal;
          getMaxSeq(strAll,minNum+1,takeNum,accMax)
       else
          getMaxSeq(strAll,minNum+1,takeNum,accMax)

let test = getMaxSeq(string,0,5,1.0)


