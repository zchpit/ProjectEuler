﻿namespace ProjectEulerInF
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
 
 allPrimes
 |> Seq.take 20 // only 20
 |> List.ofSeq // forces evaluation of first 20 items

 let FindBigestPrime =
    let rec FindBigestPrime' n =
        seq {
            if CanDivide n then
            yield n
            yield! 
        }


