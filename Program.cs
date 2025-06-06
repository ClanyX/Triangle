using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float helpNumber;
            float helpNumber1;
            float circuit;
            double content;

            Console.WriteLine("Rozpoznávač trojúhelníků\nZadej strany v cm: ");

            //adding sides
            Console.Write("A = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C = ");
            int C = Convert.ToInt32(Console.ReadLine());

            if(C < A + B && B < C + A && A < C +B)
                if(A == B && B == C && A == C)
                    Console.WriteLine("Trojúhelník je rovnostranný");
                else
                { 
                    if(A == B || B == C || A == C)
                        if(C * C == A * A + B * B || A * A == C * C - B * B || B * B == C * C - A * A)
                            Console.WriteLine("Trojúhelník je rovnoramenný pravo úhlý");
                        else
                            Console.WriteLine("Trojúhelník je rovnoramenný obecný");
                    else if(C * C == A * A + B * B || A * A == C * C - B * B || B * B == C * C - A * A)
                        Console.WriteLine("Trojúhelník je pravo úhlý");
                    else
                        Console.WriteLine("Trojúhelník je obecný");

                    //circuit of the triangual
                    circuit = A + B + C;

                    //contetn of the triangual
                    helpNumber = (A + B + C) / 2;
                    helpNumber1 = helpNumber * (helpNumber - A) * (helpNumber - B) * (helpNumber - C);
                    content = Math.Sqrt(helpNumber);

                    Console.WriteLine("Obvod trojúhelníku je {0:F2} cm\nObsah trojúhelníku je {1,5:F2} cm čtverečních", circuit, content);
                }
            else
                Console.WriteLine("Trojúhelník nelze sestrojit!!");

            Console.ReadKey();
        }
    }
}