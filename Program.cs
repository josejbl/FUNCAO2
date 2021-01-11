using System;

namespace funcoes2
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Digite a idade do ator ou atriz");
            int idade = int.Parse(Console.ReadLine());


            while (idade != 35)    
            {
               Console.WriteLine("Você Errou");
               Console.WriteLine("Digite a idade do ator ou atriz novamente");
               idade = int.Parse(Console.ReadLine());

            }    


                Console.WriteLine("Parabéns você acertou");
                

        }
    }
}
