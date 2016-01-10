namespace ProjectEulerInF
open System

module Problem2 = type T = X

//first attempt
   let rec fib n =
   if n <= 2 then 1
      else
      let a = fib (n - 1)
      let b = fib (n - 2)
      if a > 4000000
        then 0
      else
        a + b

let solution = [ for i in 1 .. 35 -> fib i] |> List.filter(fun x -> x % 2 = 0) |> List.sum


//second attempt, from Tomas Petricek via stackoverflow: http://stackoverflow.com/questions/2845744/generating-fibonacci-series-in-f

let rec fibsRec a b =
  if a + b < 4000000 then
    // The current element
    let current = a + b
    // Calculate all remaining elements recursively 
    // using 'b' as 'a' and 'current' as 'b' (in the next iteration)
    let rest = fibsRec b current  
    // Return the remaining elements with 'current' appended to the 
    // front of the resulting list (this constructs new list, 
    // so there is no mutation here!)
    current :: rest
  else 
    [] // generated all elements - return empty list once we're done

// generate list with 1, 2 and all other larger fibonaccis
let fibs = 1::2::(fibsRec 1 2)
let solution2 = fibs |> List.filter(fun x -> x % 2 = 0) |> List.sum