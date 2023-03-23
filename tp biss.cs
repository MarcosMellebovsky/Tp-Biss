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
    opcion1(ref totalPlata, ref cantCurso, ref elQueMas, ref cursoMayor,cursoYSuPlata);
    break;
    case 2:
    opcion2(  totalPlata,   cantCurso,   elQueMas,   cursoMayor,cursoYSuPlata);
    break;
    case 3:
    respuesta = opcion3(respuesta);
    break;
}
}
void opcion1(ref int totalPlata, ref int cantCurso, ref int elQueMas, ref string cursoMayor,Dictionary<string ,int> cursoYSuPlata)
{ 
int validoDeDinero, alumnos, cantAlumnos;
int totalDeCurso = 0;
string curso;
alumnos = 0;
curso = ingresarCurso("Ingresa el curso", cursoYSuPlata);
cantCurso++;
cantAlumnos = pedirAlumnos();
for (int i = 0; i < cantAlumnos-1; i++)
{
    valifarDineroDelCumple(alumnos, ref totalPlata, ref totalDeCurso, cursoYSuPlata );
}
validoDeDinero = valifarDineroDelCumple(alumnos, ref totalPlata, ref totalDeCurso,  cursoYSuPlata );
if (totalDeCurso > elQueMas )
{
    elQueMas = totalDeCurso;
    cursoMayor = curso;
}
cursoYSuPlata.Add(curso, totalDeCurso);
string ingresarCurso(string mensaje,Dictionary<string ,int> cursoYSuPlata )
{
    string curso = "";
    string verificador = "";
    Console.WriteLine(mensaje);
    while(curso == verificador )
    {
    curso=Console.ReadLine();
    foreach ( string item in cursoYSuPlata.Keys)
    {
        
        if (curso == item)
        {
            System.Console.WriteLine("curso ya ingresado");
            verificador = item;
        }
        
    }
    }
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
int valifarDineroDelCumple(int alumnos, ref int totalPlata, ref int totalDeCurso,Dictionary<string ,int> cursoYSuPlata )
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
void opcion2( int totalPlata,  int cantCurso,  int elQueMas,  string cursoMayor, Dictionary<string ,int> cursoYSuPlata)
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