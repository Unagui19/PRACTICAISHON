using Personas;

int [] arreglo1=new int[3];
int [] arreglo2={1,2,3};

int arre;
//arreglo
arreglo1[0]=1;
arre=arreglo1[0];
Console.WriteLine(arre);

Personal [] arreglo3 = new Personal[3];



//matrices
int [,] matriz1 = new int[2,2];
string [,] matriz2 = {{"a","b","c"},{"d","e","f"}};

LlenarMatriz(matriz1);


void LlenarMatriz(int[,] matriz1)
{
    int i=0,j=0;
    for (i=0; i < 2; i++)
    {
        for ( j = 0; j < 2; j++)
        {
            int rand=new Random().Next(140,203);
            matriz1[i,j]=rand;
            Console.WriteLine(matriz1[i,j]);
        }
    }

}

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

