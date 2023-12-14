using Exam.Controllers;
using ExamProblem.Models;
using ExamProblem.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestExam
{
    [TestClass]
    public class OnTimeEarlyOrLateTest
    {
        [TestMethod]
        public void AreYouEarlyTest()
        {
            
            ExamActionController exam = new ExamActionController();
            int hourOfExam = 16;
            int minuteOfExam = 00;
            int hourOfArrival = 15;
            int mituteOfArrival = 00;

           string result = exam.AreYouOnTimeLateOrEarly(hourOfExam,minuteOfExam,hourOfArrival,mituteOfArrival);
           Assert.AreEqual("You are early with 1:00 hours", result, "Error");
        }

        [TestMethod]
        public void AreYouLateTest()
        {

            ExamActionController exam = new ExamActionController();
            int hourOfExam = 9;
            int minuteOfExam = 00;
            int hourOfArrival = 10;
            int mituteOfArrival = 30;

            string result = exam.AreYouOnTimeLateOrEarly(hourOfExam, minuteOfExam, hourOfArrival, mituteOfArrival);
            Assert.AreEqual("You are late with 1:30 hours", result, "Error");
        }

        [TestMethod]
        public void AreYouLateMinutesTest()
        {

            ExamActionController exam = new ExamActionController();
            int hourOfExam = 9;
            int minuteOfExam = 30;
            int hourOfArrival = 9;
            int mituteOfArrival = 30;

            string result = exam.AreYouLateOrEarly(hourOfExam, minuteOfExam, hourOfArrival, mituteOfArrival);
            Assert.AreEqual("You are late with 20 mituse", result, "Error");
        }

        [TestMethod]
        public void AreYouEarlyMinutesTest()
        {

            ExamActionController exam = new ExamActionController();
            int hourOfExam = 9;
            int minuteOfExam = 00;
            int hourOfArrival = 8;
            int mituteOfArrival = 30;

            string result = exam.AreYouOnTimeLateOrEarly(hourOfExam, minuteOfExam, hourOfArrival, mituteOfArrival);
            Assert.AreEqual("You are early with 20 mituse", result, "Error");
        }
        [TestMethod]
        public void AreYouOnTimeTest()
        {

            ExamActionController exam = new ExamActionController();
            int hourOfExam = 9;
            int minuteOfExam = 00;
            int hourOfArrival = 9;
            int mituteOfArrival = 00;

            string result = exam.AreYouOnTimeLateOrEarly(hourOfExam, minuteOfExam, hourOfArrival, mituteOfArrival);
            Assert.AreEqual("On time", result, "Error");
        }
    }

}
