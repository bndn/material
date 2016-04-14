/// Copyright (C) 2016 The Authors.
module Material

open Color

[<NoComparison>]
type Material =
    | M of Color * float
    override m.ToString() =
        match m with
        | M(c, r) -> "[Color: " + c.ToString() + ", Reflectiveness: " + r.ToString() + "]"

/// <summary>
/// Create a material from a color and a reflective float value
/// </summary>
/// <param name=c>The color to give the material.</params>
/// <param name=r>The reflective float value</params>
/// <returns>The created material</returns>
let make c r =
    if r > 1.0 || r < 0.0
    then invalidArg "r" "Should be between 0.0 and 1.0"

    M(c,r)

/// <summary>
/// Gets the color of a given material.
/// </summary>
/// <param name=m>The material to get the color from.</params>
/// <returns>The color of the material.</returns>
let getColor (M(c, _)) = c

/// <summary>
/// Gets the reflective value of a given material.
/// </summary>
/// <param name=m>The material to get the reflective value from.</params>
/// <returns>The reflective value of the material.</returns>
let getReflect (M(_, r)) = r
