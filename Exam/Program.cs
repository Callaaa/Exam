using Exam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblem
{
    internal class Program
    {
        static void Main(string[] args)
		{
            try
            {
                ExamActionController exam = new ExamActionController();

            }
            catch(ArgumentException)
            {
                Console.WriteLine("ARGUMENT ECXEPTION");
            }
            catch (FormatException)
            {

                Console.WriteLine("WRONG FORMAT");
            }
        }
    }
}
