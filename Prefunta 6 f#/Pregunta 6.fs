// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.


open System 
let suma x y = x + y
let resta x y = x - y
let multiplicacion x y = x * y
let divicion x y = x / y
[<EntryPoint>]
let main argv = 
    Console.WriteLine("valor 1")
    let tecla1 = Console.ReadLine();
    Console.WriteLine("valor 2")
    let tecla2 = Console.ReadLine();
    let valor1 = Convert.ToInt32(tecla1);
    let valor2 = Convert.ToInt32(tecla2);
    let a = suma valor1 valor2;
    let b = resta valor1 valor2;
    let c = multiplicacion valor1 valor2;
    let d = divicion valor1 valor2;
    Console.WriteLine("Suma: "+ a.ToString())
    Console.WriteLine("Resta: "+ b.ToString())
    Console.WriteLine("Multiplicacion: "+ c.ToString())
    Console.WriteLine("Divicion: "+ d.ToString())
    let y = Console.ReadLine();
    printfn "%A" argv
    0 // devolver un código de salida entero
