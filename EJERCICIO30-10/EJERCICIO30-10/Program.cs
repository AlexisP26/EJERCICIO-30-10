using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    class Estudiante
    { public int Estrato {  get; set; }
    public int Creditos {  get; set; }
    public double ValorCredito { get; set; }
    public double PrecioMatricula { get; private set; }
    public double Subsidio {  get; private set; }
    
    public Estudiante(int ESTRATO, int CREDITOS, double VALORCREDITO)
        {  Estrato = ESTRATO; Creditos = CREDITOS; ValorCredito = VALORCREDITO;} 

    public void CalcularMatricula() 
        { if (Creditos <= 20) { PrecioMatricula = Creditos * ValorCredito; }
        else { int CreditosExtra= Creditos-20; PrecioMatricula=20*ValorCredito;
        PrecioMatricula = PrecioMatricula + (CreditosExtra * ValorCredito * 2);}

     if (Estrato == 1) { PrecioMatricula *= 0.2; }
     else if (Estrato == 2) { PrecioMatricula *= 0.5; }
     else if (Estrato == 3) { PrecioMatricula *= 0.7; }}
    
    public void CalcularSubsidio()
        { if (Estrato == 1) { Subsidio = 200000; }
        else if (Estrato == 2) { Subsidio = 100000; } }

    public void Mostrarinformacion()
    { Console.WriteLine($"El precio de la matricula es: $ {PrecioMatricula} ");
      Console.WriteLine($"el valor del subsidio es: $ {Subsidio} ");}
     
        
     static void main()
      { bool continuar = true;
        while (continuar)
      { Console.WriteLine("Ingrese el estrato del estudiante (1_3):");
        int Estrato = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de creditos a tomar:");
        int Creditos = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del credito:");
        double valorCredito = int.Parse(Console.ReadLine());

     

            }
                    
                    }


        }
            





    }
