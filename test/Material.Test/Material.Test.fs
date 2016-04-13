/// Copyright (C) 2016 The Authors.
module Material.Test

open Color
open Xunit;
open FsUnit.Xunit;

[<Fact>]
let ``make constructs a material from a color and a reflective value``() =
    let m = Material.make (Color.make 0.56 0.44 0.1) 0.2

    // Check that material was constructed
    m |> should be instanceOfType<Material>

[<Fact>]
let ``make fails if reflective value is less than 0.0``() =
    let c = Color.make 0.56 0.44 0.1

    (fun f -> Material.make c -0.4 |> ignore) |> shouldFail

[<Fact>]
let ``make fails if reflective value is more than 1.0``() =
    let c = Color.make 0.56 0.44 0.1

    (fun f -> Material.make c 2.4 |> ignore) |> shouldFail

[<Fact>]
let ``getColor retrieves the color of a material``() =
    let m = Material.make (Color.make 0.56 0.44 0.1) 0.2
    let c = Material.getColor m

    // Check that we have our color
    c |> should be instanceOfType<Color>

    // Check our color values
    abs (Color.getR c - 0.56) |> should be (lessThan 0.01)
    abs (Color.getG c - 0.44) |> should be (lessThan 0.01)
    abs (Color.getB c - 0.1) |> should be (lessThan 0.01)

[<Fact>]
let ``getReflect retrieves the reflective value of a material``() =
    let m = Material.make (Color.make 0.56 0.44 0.1) 0.2

    abs (Material.getReflect m - 0.2) |> should be (lessThan 0.01)
