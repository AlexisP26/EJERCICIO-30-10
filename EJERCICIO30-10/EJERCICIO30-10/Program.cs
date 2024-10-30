using System;

class Program
{
    class Estudiante
    { public int Estrato {  get; set; }
    public int Creditos {  get; set; }
    public double ValorCredito { get; set; }
    public double PrecioMatricula { get; private set; }
    public double Subcidio {  get; private set; }
    
    public Estudiante(int ESTRATO, int CREDITOS, double VALORCREDITO)
        {  Estrato = ESTRATO; Creditos = CREDITOS; ValorCredito = VALORCREDITO;} 

    public void CalcularMatricula() 
        { if (Creditos <= 20) { PrecioMatricula = Creditos * ValorCredito; }
        else { int CreditosExtra= Creditos-20; PrecioMatricula=20*ValorCredito;
        PrecioMatricula += CreditosExtra * ValorCredito * 2;
     if (Estrato == 1) { PrecioMatricula *= 0.2; }
     if (Estrato == 2) { PrecioMatricula *= 0.5; }
     if (Estrato == 3) { PrecioMatricula *= 0.7; }

            }
        }
            





    }
}