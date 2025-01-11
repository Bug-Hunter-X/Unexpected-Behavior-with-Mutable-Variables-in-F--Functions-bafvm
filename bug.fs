let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printf "%d" result //This will print 30

x <- 15 //Modifying x after calling the function

let result2 = add x y
printf "%d" result2 //This will still print 30, not 35