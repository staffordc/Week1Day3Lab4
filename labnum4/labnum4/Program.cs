using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labnum4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool LoopRunProgram = true;
            while (LoopRunProgram == true)
            {

                //enter an integer USER
                Console.WriteLine("USER, PLEASE FEED ME A NUMBER! AN INTEGER!");
                int UserNumber = Int32.Parse(Console.ReadLine());

                //display a table of squares and cubes from 1 to Userinteger
                String s = String.Format("{0,-10} {1,-10} {2,-10}\n\n", "Number", "Squared", "Cubed");
                string Equ = string.Format("{0,-10} {1,-10} {2,-10}", "===========", "===========", "===========");
                Console.WriteLine($"\n{s}\n{Equ}\n");
                for (var i = 1; i <= UserNumber; i++)
                {
                    String num = String.Format("{0,-10} {1,-10} {2,-10}", i, (i * i), (i * i * i));
                    
                    Console.WriteLine($"\n{num}");
                }


                Console.WriteLine();

                //prompts user to continue (y/n)
                string Response = ("Wanna start again? (y/n)");
                bool end = true;
                while (end)
                {
                    Console.WriteLine(Response);
                    string UserRestart = Console.ReadLine();


                    if (UserRestart == "y")
                    {
                        LoopRunProgram = true;
                        end = false;
                    }
                    else if (UserRestart == "n")
                    {
                        LoopRunProgram = false;
                        end = false;
                    }
                    else
                    {
                        Console.WriteLine("I don't know what you're trying to say, is that a Y or an N?");
                        end = true;
                    }

                }
            }
        }
    }
}