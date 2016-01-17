namespace ProjectEulerInF
open System

 let isPrime n =
    let sqrt' = (float >> sqrt >> float) n // square root of integer
    [ 2.0 .. sqrt' ] // all numbers from 2 to sqrt'
    |> List.forall (fun x -> n % x <> 0.0) // no divisors
 
 let allPrimes =
   let rec allPrimes' n =
     seq { // sequences are lazy, so we can make them infinite
       if isPrime n then
         yield n
       yield! allPrimes' (n+1.0) // recursing
     }
   allPrimes' 2.0 // starting from 2
 
 let primes = allPrimes |> Seq.take 2000  |> List.ofSeq 

 let solution = primes |> List.filter(fun x -> 600851475143.0 % x = 0.0) |> List.max


