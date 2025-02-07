let x = 10
let y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

//Modifying x and y here will not affect the previous result
let x2 = 15
let y2 = 25

let z2 = add x2 y2
printf "%d\n" z2

//To get the desired behavior, the function itself should modify the variables:
let mutable x3 = 10
let mutable y3 = 20

let addInPlace (x:byref<int>) (y:byref<int>) = 
    x <- x + y

addInPlace &x3 &y3 //Note the use of & to pass by reference.
printf "%d\n" x3