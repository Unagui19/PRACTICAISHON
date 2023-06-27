using Personas;

int [] arreglo1=new int[3];
int [] arreglo2={1,2,3};

int arre;
//arreglo
arreglo1[0]=1;
arre=arreglo1[0];
Console.WriteLine(arre);

Personal [] arreglo3 = new Personal[3];

foreach (var pj in arreglo3)
{
    var personita =new Personal();
    personita.Altura= new Random().Next(140,203);
}


//matrices
int [,] matriz1 = new int[2,2];
string [,] matriz2 = {{"a","b","c"},{"d","e","f"}};


