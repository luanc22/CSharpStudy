using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    internal class Exercises2
    {
        static void Main(string[] args)
        {
            Divisor(11);

            Console.Write("Tell me your age: ");
            string inputAge = Console.ReadLine();
            int inputAgeNum = int.Parse(inputAge);

            Console.WriteLine("");
            Console.WriteLine("You look older than " + inputAgeNum);

            Divisor(12);

            Console.Write("Enter a number: ");
            string inputBlk = Console.ReadLine();
            int inputBlkNum = int.Parse(inputBlk);

            Console.WriteLine("");
            Console.WriteLine(inputBlkNum + " " + inputBlkNum + " " + inputBlkNum + " " + inputBlkNum + " ");
            Console.WriteLine(inputBlkNum + "" + inputBlkNum + "" + inputBlkNum + "" + inputBlkNum + "");
            Console.WriteLine("{0} {0} {0} {0} ", inputBlkNum);
            Console.WriteLine("{0}{0}{0}{0}", inputBlkNum);

            Divisor(13);

            Console.Write("Enter a number: ");
            string inputRect = Console.ReadLine();
            int inputRectNum = int.Parse(inputRect);

            Console.WriteLine("");
            Console.WriteLine(" {0}{0}{0}", inputRectNum);
            Console.WriteLine("{0}   {0}", inputRectNum);
            Console.WriteLine("{0}   {0}", inputRectNum);
            Console.WriteLine("{0}   {0}", inputRectNum);
            Console.WriteLine(" {0}{0}{0}", inputRectNum);

            Divisor(14);

            Console.Write("Enter the amount of celsius: ");
            string inputCel = Console.ReadLine();
            float inputCelNum = float.Parse(inputCel);

            float fahr = inputCelNum + 56.0f;
            float kelv = inputCelNum + 273.0f;

            Console.WriteLine("");
            Console.WriteLine("Fahrenheit = {0}", fahr);
            Console.WriteLine("Kelvin = {0}", kelv);

            Divisor(15);

            Console.WriteLine(Remover("w3resource", 1));
            Console.WriteLine(Remover("w3resource", 9));
            Console.WriteLine(Remover("w3resource", 0));

            Divisor(16);

            Console.WriteLine(Changer("w3resource"));
            Console.WriteLine(Changer("Python"));

            Divisor(17);

            Console.Write("Input a string: ");
            string inputStr = Console.ReadLine();

            if(inputStr.Length >= 1)
            {
                string firstLetter = inputStr.Substring(0, 1);
                Console.WriteLine("");
                Console.WriteLine("Result: " + firstLetter + inputStr + firstLetter);
            }
            else
            {
                Console.WriteLine("Input strings with more than one letter!");
            }

            Divisor(18);

            Console.Write("Write the first number: ");
            string inputNPF = Console.ReadLine();
            int inputNPFNum = int.Parse(inputNPF);
            Console.Write("Write the second number: ");
            string inputNPS = Console.ReadLine();
            int inputNPSNum = int.Parse(inputNPS);

            bool cond;

            if (inputNPFNum > 0 && inputNPSNum < 0)
            {
                cond = true;
            }
            else if (inputNPFNum < 0 && inputNPSNum > 0)
            {
                cond = true;
            }
            else
            {
                cond = false;
            }

            Console.WriteLine("Check if one is negative and one is positive: " + cond);

            Divisor(19);

            int varA = 10;
            int varB = 10;

            int sumAB = varA + varB;

            if (varA == varB)
            {
                Console.WriteLine("OH BABY A TRIPLE");
                Console.WriteLine(3 * sumAB);
            }
            else
            {
                Console.WriteLine("Sum is: " + sumAB);
            }

            Divisor(20);

            int varC = 30;
            int varD = 20;

            int subCD = varC - varD;
            
            if(varC > varD)
            {
                Console.WriteLine("ITS TIME FOR DOUBLE TROUBLE");
                Console.WriteLine(2 * subCD);
            }
            else
            {
                Console.WriteLine("Sub is: " + subCD);
            }

            Console.ReadLine();





        }

        static string Remover(string wordOne,int letter)
        {
            return wordOne.Remove(letter, 1);
        }

        static string Changer(string wordTwo)
        {
            return wordTwo.Length > 1
                ? wordTwo.Substring(wordTwo.Length - 1) + wordTwo.Substring(1, wordTwo.Length - 2) + wordTwo.Substring(0, 1) : wordTwo;
        }

        static void Divisor(int numeroEx)
        {
            Console.WriteLine("");
            Console.WriteLine("============");
            Console.WriteLine("Exercicio " + numeroEx);
            Console.WriteLine("");
        }
    }
}
