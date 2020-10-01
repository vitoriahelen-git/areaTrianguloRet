using System;

namespace areaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorbase; 
            double valoraltura;
            double valorarea;


            Console.WriteLine("Calcule a área de um triângulo retângulo:\n");
            
            Console.Write("Base:");
            valorbase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura:");
            valoraltura = Convert.ToDouble(Console.ReadLine());
            valorarea = (valorbase * valoraltura) / 2;
            Console.WriteLine($"Area:{valorarea}");
            









        }
    }
}
