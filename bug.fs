let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d" z

x <- 15 //This is the part that could cause confusion
y <- 25

let z2 = add x y
printf "%d" z2