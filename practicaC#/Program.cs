using Personas;

var Franco = new Personal();

Franco.Nombre = "Franco";
Franco.Altura =172;
Franco.Nacionalidad= "Argentina";
Franco.Profesión ="Estudiante de Ingeniería en Informática";
Franco.FechaNac=new DateTime(1996, 12, 19);
Franco.calcularEdad(Franco.FechaNac);

Console.WriteLine(Franco.Nombre);
Console.WriteLine(Franco.Altura);
Console.WriteLine(Franco.Nacionalidad);
Console.WriteLine(Franco.Profesión);
Console.WriteLine(Franco.FechaNac);
Console.WriteLine(Franco.Edad);





// string? hola="hola";
// var saludar = new saludando(hola);
// Console.WriteLine(saludar.Saludo);
// saludar.Saludo="chau";
// Console.WriteLine(hola);
// hola=saludar.Saludo;
// Console.WriteLine(hola);

// class saludando
// {
//     private string? saludo;
//     public string? Saludo { get => saludo; set => saludo = value; }
//     public saludando(string? saludo)
//     {
//         this.Saludo = saludo;
//     }

// }



