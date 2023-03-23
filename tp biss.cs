using System.Collections.Generic;
Dictionary<string ,int> cursoYSuPlata = new Dictionary<string,int>();
int opciones;
string respuesta = "";
int masPlata = 0;
int totalPlata = 0;
int cantCurso = 0;
int elQueMas = 0;
string cursoMayor = "";
while(respuesta != "si")
{
System.Console.WriteLine("ingresa \n 1: los importes de un curso \n 2: ver estadistica \n 3: terminar ");
opciones = int.Parse(Console.ReadLine());
Console.Clear();
switch (opciones)
{
    case 1:
    opcion1(ref totalPlata, ref cantCurso, ref elQueMas, ref cursoMayor);
    break;
    case 2:
    opcion2(  totalPlata,   cantCurso,   elQueMas,   cursoMayor);
    break;
    case 3:
    respuesta = opcion3(respuesta);
    break;
}
}
void opcion1(ref int totalPlata, ref int cantCurso, ref int elQueMas, ref string cursoMayor)
{ 
int validoDeDinero, alumnos, cantAlumnos;
int totalDeCurso = 0;
string curso;
alumnos = 0;
curso = ingresarCurso("Ingresa el curso");
cantCurso++;
cantAlumnos = pedirAlumnos();
for (int i = 0; i < cantAlumnos-1; i++)
{
    valifarDineroDelCumple(alumnos, ref totalPlata, ref totalDeCurso);
}
validoDeDinero = valifarDineroDelCumple(alumnos, ref totalPlata, ref totalDeCurso );
if (totalDeCurso > elQueMas )
{
    elQueMas = totalDeCurso;
    cursoMayor = curso;
}
string ingresarCurso(string mensaje)
{
    string curso;
    Console.WriteLine(mensaje);
    curso=Console.ReadLine();
    return curso;
}
int pedirAlumnos()
{
     System.Console.WriteLine("Ingrese cuantos alumnos son en la division: "); 
    alumnos = int.Parse(Console.ReadLine());
    while(alumnos < 0)
    {
        System.Console.WriteLine("No existe esa cantidad de alumnos en una division ");
        alumnos = int.Parse(Console.ReadLine());
    } 
return alumnos;
}
int valifarDineroDelCumple(int alumnos, ref int totalPlata, ref int totalDeCurso)
{
    int regalo;
    System.Console.WriteLine("Ingrese cuanta cantidad le va a regalar al cumplañero: ");
    regalo = int.Parse(Console.ReadLine());
    while (regalo <= 0 )
    {
        System.Console.WriteLine("La cantidad que le intentaste regalar al cumplañero no es valida ");
        regalo = int.Parse(Console.ReadLine());
    }
    totalPlata = totalPlata + regalo;
    totalDeCurso = totalDeCurso + regalo;
    return regalo;
}
}
void opcion2( int totalPlata,  int cantCurso,  int elQueMas,  string cursoMayor)
{
    int promedio  = totalPlata/cantCurso;
    System.Console.WriteLine("El curso " + cursoMayor + " fue el que mas regalo con un total de: " + elQueMas + " pesos");
    System.Console.WriteLine("La cantidad de plata de las diviciones son: " + totalPlata);
    System.Console.WriteLine("El promedio es: " + promedio);
    System.Console.WriteLine("La cantidad de cursos que regalaron plata fueron: "+ cantCurso);
}
string opcion3(string respuesta)
{
    string usuario;
    System.Console.WriteLine("Desa terminar el programa? ");
    usuario = Console.ReadLine();
    return usuario;
}
