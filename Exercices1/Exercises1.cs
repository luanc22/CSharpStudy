using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1
{
    internal class Exercices1
    {
        static void Main(string[] args)
        {
            Divisor(1);

            Console.Write("Hello: ");
            Console.WriteLine("Luan Cabral");

            Divisor(2);

            int varA = 10;
            int varB = 10;
            int sumAB = 0;

            sumAB = varA + varB;

            Console.WriteLine(sumAB);

            Divisor(3);

            int varC = 10;
            int varD = 2;
            int divCD = 0;

            divCD = varC / varD;

            Console.WriteLine(divCD);   

            Divisor(4);

            int primeiraOp = -1 + 4 * 6;
            int segundaOp = (35 + 5) % 7;
            int terceiraOp = 14 + -4 * 6 / 11;
            int quartaOp = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(primeiraOp);
            Console.WriteLine(segundaOp);
            Console.WriteLine(terceiraOp);
            Console.WriteLine(quartaOp);

            Divisor(5);

            Console.Write("Input the first number: ");
            string inputSumOne = Console.ReadLine();
            int inputNumSumOne = int.Parse(inputSumOne);
            Console.Write("Input the second number: ");
            string inputSumTwo = Console.ReadLine();
            int inputNumSumTwo = int.Parse(inputSumTwo);

            int temp = 0;
            temp = inputNumSumOne;
            inputNumSumOne = inputNumSumTwo;
            inputNumSumTwo = temp;

            Console.WriteLine("");
            Console.WriteLine("First number: " + inputNumSumOne);
            Console.WriteLine("Second number: " + inputNumSumTwo);

            Divisor(6);

            Console.Write("Input the first number to multiply: ");
            string inputMtpOne = Console.ReadLine();
            float inputNumMtpOne= float.Parse(inputMtpOne);
            Console.Write("Input the second number to multiply: ");
            string inputMtpTwo = Console.ReadLine();
            float inputNumMtpTwo = float.Parse (inputMtpTwo);
            Console.Write("Input the third number to multiply: ");
            string inputMtpThree = Console.ReadLine();
            float inputNumMtpThree = float.Parse(inputMtpThree);

            float outputMultiply = 0;
            outputMultiply = inputNumMtpOne * inputNumMtpTwo * inputNumMtpThree;

            Console.WriteLine();
            Console.WriteLine(inputNumMtpOne + " x " + inputNumMtpTwo + " x " + inputNumMtpThree + " = " + outputMultiply);

            Divisor(7);

            Console.Write("Input the fist number: ");
            string inputAccOne = Console.ReadLine();
            int inputAccNumOne = int.Parse(inputAccOne);
            Console.Write("Input the second number: ");
            string inputAccTwo = Console.ReadLine();
            int inputAccNumTwo = int.Parse(inputAccTwo);

            int accSum = inputAccNumOne + inputAccNumTwo;
            int accSub = inputAccNumOne - inputAccNumTwo;
            int accMtp = inputAccNumOne * inputAccNumTwo;
            int accDiv = inputAccNumOne / inputAccNumTwo;
            int accMod = inputAccNumOne % inputAccNumTwo;

            Console.WriteLine("");

            Console.WriteLine(inputAccNumOne + " + " + inputAccNumTwo + " = " + accSum);
            Console.WriteLine(inputAccNumOne + " - " + inputAccNumTwo + " = " + accSub);
            Console.WriteLine(inputAccNumOne + " x " + inputAccNumTwo + " = " + accMtp);
            Console.WriteLine(inputAccNumOne + " / " + inputAccNumTwo + " = " + accDiv);
            Console.WriteLine(inputAccNumOne + " % " + inputAccNumTwo + " = " + accMod);

            Divisor(8);

            Console.Write("Enter the number: ");
            string inputTblOne = Console.ReadLine();
            int inputTblNumOne = int.Parse(inputTblOne);

            Console.WriteLine("");

            Console.WriteLine(inputTblNumOne + " * 1 = " + inputTblNumOne * 1);
            Console.WriteLine(inputTblNumOne + " * 2 = " + inputTblNumOne * 2);
            Console.WriteLine(inputTblNumOne + " * 3 = " + inputTblNumOne * 3);
            Console.WriteLine(inputTblNumOne + " * 4 = " + inputTblNumOne * 4);
            Console.WriteLine(inputTblNumOne + " * 5 = " + inputTblNumOne * 5);
            Console.WriteLine(inputTblNumOne + " * 6 = " + inputTblNumOne * 6);
            Console.WriteLine(inputTblNumOne + " * 7 = " + inputTblNumOne * 7);
            Console.WriteLine(inputTblNumOne + " * 8 = " + inputTblNumOne * 8);
            Console.WriteLine(inputTblNumOne + " * 9 = " + inputTblNumOne * 9);
            Console.WriteLine(inputTblNumOne + " * 10 = " + inputTblNumOne * 10);

            Divisor(9);

            Console.Write("Enter the First number: ");
            string inputMedOne = Console.ReadLine();
            int inputMedNumOne = int.Parse(inputMedOne);
            Console.Write("Enter the Second number: ");
            string inputMedTwo = Console.ReadLine();
            int inputMedNumTwo = int.Parse(inputMedTwo);
            Console.Write("Enter the Third number: ");
            string inputMedThree = Console.ReadLine();
            int inputMedNumThree = int.Parse(inputMedThree);
            Console.Write("Enter the Fourth number: ");
            string inputMedFour = Console.ReadLine();
            int inputMedNumFour = int.Parse(inputMedFour);

            int avgNums = (inputMedNumOne + inputMedNumTwo + inputMedNumThree + inputMedNumFour) / 4;

            Console.WriteLine("");
            Console.WriteLine("The average of " + inputMedNumOne + ", " + inputMedNumTwo + ", " + inputMedNumThree + ", " + inputMedNumFour + " = " + avgNums);

            Divisor(10);

            Console.Write("Enther the first number: ");
            string inputX = Console.ReadLine();
            int inputXNum = int.Parse(inputX);
            Console.Write("Enther the second number: ");
            string inputY = Console.ReadLine();
            int inputYNum = int.Parse(inputY);
            Console.Write("Enther the Third number: ");
            string inputZ = Console.ReadLine();
            int inputZNum = int.Parse(inputZ);

            int opOne = (inputXNum + inputYNum) * inputZNum;
            int opTwo = inputXNum * inputYNum + inputYNum * inputZNum;
            Console.WriteLine("");
            Console.WriteLine("Result of specified numbers " + inputXNum + ", " + inputYNum + " and " + inputZ + ", (x+y).z = " + opOne + " and x.y + y.z = " + opTwo);
            Console.ReadLine();

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
