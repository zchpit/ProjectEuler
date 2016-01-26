
 let isPrime n =
    let sqrt' = (float >> sqrt >> float) n // square root of integer
    [ 2.0 .. sqrt' ] // all numbers from 2 to sqrt'
    |> List.forall (fun x -> n % x <> 0.0) // no divisors
 
 let allPrimes =
   let rec allPrimes' n =
     seq { 
        if n < 2000000.0 then
            if isPrime n then
              yield n
            yield! allPrimes' (n+1.0) // recursing
     }
   allPrimes' 2.0 // starting from 2
 
 let primes = allPrimes |> List.ofSeq 
 let solution = primes |> List.sum