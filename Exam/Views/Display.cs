using ExamProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExamProblem.Models.Model;

namespace ExamProblem.Views
{
    public class Display
    {
        public string Message { get; set; }
        public int HourOfExam { get; set; }

        public int MinuteOfExam { get; set; }

        public int HourOfArrival { get; set; }

        public int MinuteOfArrival { get; set; }



        public void Input()
        {
            Console.WriteLine("Enter Hour Of Exam");
            HourOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute Of Exam");
            MinuteOfExam = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hour Of Arrival");
            HourOfArrival = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute Of Arrival");
            MinuteOfArrival = int.Parse(Console.ReadLine());
        }
        public void Output() 
        {
            Console.WriteLine(Message);
        }
    }
}
