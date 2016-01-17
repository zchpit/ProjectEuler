

namespace Application2
open System

module Problem5 = type T = X


let rec isDivided (n: int, m: int) =
     if m = 1 then true
     else
        if
           n % m <> 0 then false
        else
           isDivided (n, m-1)

let check = isDivided (2520,10)


let solution = seq {5 .. 500000000} |> Seq.filter(fun x -> isDivided(x,20)) |> Seq.min


