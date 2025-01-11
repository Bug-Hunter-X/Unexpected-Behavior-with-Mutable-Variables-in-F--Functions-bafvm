let mutable x = 10
let mutable y = 20

let addByRef (x:byref<int>) y = x <- x + y // Using byref for modification

let result = addByRef &x y // Passing by reference using & operator
printf "%d" result // This will print 30

x <- 15 //Modifying x 

let result2 = addByRef &x y // Calling the function again after modification
printf "%d" result2 // This will print 35

//Alternative Solution using ref cell
let xRef = ref 10
let yRef = ref 20

let addRefCell (x:int ref) (y:int ref) = x := !x + !y

let result3 = addRefCell xRef yRef
printf "%d" !xRef //This will print 30

xRef := 15

let result4 = addRefCell xRef yRef
printf "%d" !xRef //This will print 35