module HelloWorld

let rec calculatingtailFactorial n acc =
    if n <= 1 then
        acc
    else
        calculatingtailFactorial (n - 1) (n * acc)

// Using this function to calculate the factorial of 5
let factorialOf5 = calculatingtailFactorial 5 1
printfn "Factorial of 5 is: %A" factorialOf5
