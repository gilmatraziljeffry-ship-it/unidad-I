
using System;

namespace EjercicioConstructores
{
    // 1. Clase Circulo
    public class Circulo
    {
        
        private double radio;

        // 2. Constructores

  
        public Circulo()
        {
            this.radio = 1.0;
        }

        
        public Circulo(double radio)
        {
            if (radio > 0)
            {
                this.radio = radio;
            }
            else
            {
                Console.WriteLine(">>> ERROR: El radio debe ser mayor que 0. Se asignará 1.0 por defecto.");
                this.radio = 1.0;
            }
        }

        // 3. Métodos

        
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        
        public double CalcularCircunferencia()
        {
            return 2 * Math.PI * radio;
        }

        
        public double GetRadio() => radio;
    }

    // 4. Clase de Prueba (Program.cs)
    class Program
    {
        static void Main(string[] args)
        {
          
            Circulo c1 = new Circulo();            
            Circulo c2 = new Circulo(5.0);        

            
            Console.WriteLine("--- Círculo 1 (Constructor por defecto) ---");
            Console.WriteLine($"Radio: {c1.GetRadio()}");
            Console.WriteLine($"Área: {c1.CalcularArea():F4}");
            Console.WriteLine($"Circunferencia: {c1.CalcularCircunferencia():F4}");

            
            Console.WriteLine("\n--- Círculo 2 (Radio = 5.0) ---");
            Console.WriteLine($"Radio: {c2.GetRadio()}");
            Console.WriteLine($"Área: {c2.CalcularArea():F4}");
            Console.WriteLine($"Circunferencia: {c2.CalcularCircunferencia():F4}");

          
            Console.WriteLine("\n--- Prueba de Validación (Radio = -3.0) ---");
            Circulo c3 = new Circulo(-3.0);

            Console.ReadKey();
        }
    }
}