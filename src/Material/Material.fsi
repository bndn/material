/// Copyright (C) 2016 The Authors.
module Material

open Color

type Material

/// <summary>
/// Create a material from a color and a reflective float value
/// </summary>
/// <param name=c>The color to give the material.</params>
/// <param name=r>The reflective float value</params>
/// <returns>The created material</returns>
val make : c:Color -> r:float -> Material

/// <summary>
/// Gets the color of a given material.
/// </summary>
/// <param name=m>The material to get the color from.</params>
/// <returns>The color of the material.</returns>
val getColor : m:Material -> Color

/// <summary>
/// Gets the reflective value of a given material.
/// </summary>
/// <param name=m>The material to get the reflective value from.</params>
/// <returns>The reflective value of the material.</returns>
val getReflect : m:Material -> float
