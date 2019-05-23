using System;

namespace TratamentoDeExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e )
            {
                Console.WriteLine("Não é possível fazer divisão por 0: " + e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Não é possível fazer a divisão de LETRAS: " + e);
            }
        }
    }
}
