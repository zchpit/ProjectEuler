namespace ProjectEulerInF
open System

 let isPrime n =
    let sqrt' = (float >> sqrt >> int) n // square root of integer
    [ 2 .. sqrt' ] // all numbers from 2 to sqrt'
    |> List.forall (fun x -> n % x <> 0) // no divisors
 
 let allPrimes =
   let rec allPrimes' n =
     seq { // sequences are lazy, so we can make them infinite
       if isPrime n then
         yield n
       yield! allPrimes' (n+1) // recursing
     }
   allPrimes' 2 // starting from 2
 
 let primes = allPrimes |> Seq.take 200  |> List.ofSeq 


 let solution = primes |> List.filter(fun x -> 13195 % x = 0)


