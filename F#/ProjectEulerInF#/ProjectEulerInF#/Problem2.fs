namespace ProjectEulerInF
open System

module Problem2 = type T = X


   let rec fib n =
   if n <= 2 then 1
      else
        let a = fib (n - 1)
        let b = fib (n - 2)

        a + b


let solution = [ for i in 1 .. 35 -> fib i] |> List.filter(fun x -> x % 2 = 0) |> List.sum




