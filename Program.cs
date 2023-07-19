using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARKSHEET_APPLICATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NAME");
            string NAME = Console.ReadLine();

            Console.WriteLine("ENTER YOUR ROLL NUMBER");
            string ROLL = Console.ReadLine();

            Console.WriteLine("ENTER YOUR CLASS");
            string STANDERED = Console.ReadLine();

            Console.WriteLine("ENTER HINDI MARKS");
            int H = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR MATH MARKS");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR ENGLISH MARKS");
            int E = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR PHYSICS MARKS");
            int P = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER YOUR CHEMISTY NUMBER");
            int C = int.Parse(Console.ReadLine());

            int OBT = H + M + E + P + C;
            int PER = OBT * 100 / 500;

            Console.WriteLine("----------MARKSHEET----------");

            Console.WriteLine("YOUR NAME IS : {0}", NAME);
            Console.WriteLine("YOUR CLASS IS : {0} ", STANDERED);
            Console.WriteLine("YOUR ROLL NUMBER IS : {0} ", ROLL);



            Console.WriteLine("YOUR OBTAINED MARKS: {0} ", OBT);
            Console.WriteLine("YOUR PERCENTAGE IS : {0}", PER);



            if (PER >= 85)
            {
                Console.WriteLine("GRADE: A-1");
            }
            else if (PER >= 75)
            {
                Console.WriteLine("GRADE: A");
            }
            else if (PER >= 65)
            {
                Console.WriteLine("GRADE: B");
            }
            else if (PER >= 55)
            {
                Console.WriteLine("GRADE: C");
            }
            else if (PER >= 33)
            {
                Console.WriteLine("GRADE: D");
            }
            else
            {
                Console.WriteLine("YOU ARE FAIL :");
            }


            if (PER >= 85)
            {
                Console.WriteLine("REMARKS: EXCELENT");
            }
            else if (PER >= 75)
            {
                Console.WriteLine("REMARKS: VERY GOOD");
            }
            else if (PER >= 65)
            {
                Console.WriteLine("REMARKS: GOOD");
            }
            else if (PER >= 55)
            {
                Console.WriteLine("REMARKS: FAIR)");
            }
            else if (PER >= 33)
            {
                Console.WriteLine("REMARKS: POOR");
            }
            else
            {
                Console.WriteLine("REMARKS: BRING YOUR PARENTS TOMORROW !!");
            }
            //int OBT = H + M + E + P + C;

            int supplyment = 0;

            if (H < 33)
            {
                supplyment++;
            }
            if (M < 33)
            {
                supplyment++;
            }
            if (E < 33)
            {
                supplyment++;
            }
            if (P < 33)
            {
                supplyment++;
            }
            if (C < 33)
            {
                supplyment++;
            }

            Console.WriteLine("YOU ARE FAILED IN {0} SUBJECTS", supplyment);





            Console.ReadLine();




        }
    }
}
