using Personas;

// ENUM

mes mesActual = mes.Enero;
Console.WriteLine(mesActual);//aqui me devuelve el string 
Console.WriteLine((int)mesActual); //aqui en numero

mes miMes = mes.Febrero | mes.Febrero;
Console.WriteLine((int)miMes);//me devuelve la suma de los enum mencionados


[Flags]
enum mes
{
    Enero = 1,
    Febrero = 2,
    Marzo =3,
    Abril = 4,
    Mayo = 5,
    Junio = 6    
}

// //--------------------COLECCIONES

// List<int> lista= new List<int>(); //inicializo lista
// Dictionary<int,string> diccionario=new Dictionary<int, string>();//inicializo diccionario 

// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// Console.WriteLine("Diccionario:");
// mostrarDiccionario(diccionario);

// //agregar elementos
// lista.Add(3);
// lista.Add(5);
// Console.WriteLine("Lista: "+lista+"\n");
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// diccionario.Add(1,"a");
// diccionario.Add(2,"b");
// Console.WriteLine("Diccionario: ");
// mostrarDiccionario(diccionario);

// //quitar elementos
// lista.Remove(3);
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// diccionario.Remove(1);
// Console.WriteLine("Diccionario: ");
// mostrarDiccionario(diccionario);

// //concatenar elementos
// lista.Concat(lista);//solo funciona en strings
// Console.WriteLine("Lista: ");
// mostrarLista(lista);



// void mostrarLista (List<int> lista)
// {
//     foreach (var item in lista)
//     {
//         Console.WriteLine(item);
//     }
// }

// void mostrarDiccionario (Dictionary<int,string> diccionario)
// {
//     foreach (var item in diccionario)
//     {
//         Console.WriteLine(item);
//     }
// }

// //ARREGLOS Y MATRICES
// int [] arreglo1=new int[3];
// int [] arreglo2={1,2,3};

// int arre;
// //arreglo
// arreglo1[0]=1;
// arre=arreglo1[0];
// Console.WriteLine(arre);

// Personal [] arreglo3 = new Personal[3];



// //matrices
// int [,] matriz1 = new int[2,2];
// string [,] matriz2 = {{"a","b","c"},{"d","e","f"}};


//dato generico <T> (NO SALIO)
// MiClase<int> instancia = new MiClase<int>();

// //listas
// public class MiClase <T>
// {
//     T Value;

//     public T Value1 { get => Value; }

//     public MiClase(T t)
//     {
//         Value=t;
//     }
// }





// LlenarMatriz(matriz1);


// void LlenarMatriz(int[,] matriz1)
// {
//     int i=0,j=0;
//     for (i=0; i < 2; i++)
//     {
//         for ( j = 0; j < 2; j++)
//         {
//             int rand=new Random().Next(140,203);
//             matriz1[i,j]=rand;
//             Console.WriteLine(matriz1[i,j]);
//         }
//     }



// FOREACH PARA COPIAS SIN METODO (UNA CACA)
// foreach (var item in arreglo3)
// {
//     // int rand=new Random().Next(140,203);
    
//     var rand = new Random();
//     var pers = new Personal();
//     pers.Nombre=""+i;
//     pers.Altura=rand.Next(140,205);
//     Console.WriteLine(pers.Nombre);
//     Console.WriteLine(pers.Altura);
//     i++;
// }

