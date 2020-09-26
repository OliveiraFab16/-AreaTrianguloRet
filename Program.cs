using System;

namespace _AreaTrianguloRet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base;
            double Altura; 
            double Area;
            
            Console.Write("Valor da Base em (cm): ");
            Base = double.Parse(Console.ReadLine());

            Console.Write(" Valor da Altura em (cm): ");
            Altura = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"A Area do Triangulo é: {Area = Base * Altura / 2} (cm²)");
            Console.ForegroundColor = ConsoleColor.Green;
             
            


            
            

            
        }
    }
}
