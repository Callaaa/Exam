using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExamProblem.Models
{
    public class Model
    {
        private int hourOfExam;
        private int minuteOfExam;
        private int hourOfArrival;
        private int minuteOfArrival;
        public string Message { get; set; }

        public int HourOfExam
        {
            get { return hourOfExam; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException("HOUR OF EXAM IS OUT OF RANGE");
                }
                this.hourOfExam = value;
            }
        }
        public int MinuteOfExam
        {
            get { return minuteOfExam; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("MINUTE OF EXAM IS OUT OF RANGE");
                }
                this.minuteOfExam = value;
            }
        }
        public int HourOfArrival
        {
            get { return hourOfArrival; }
            set
            {
                if (value < 0 || value >= 24)
                {
                    throw new ArgumentOutOfRangeException("HOUR OF ARRIVAL IS OUT OF RANGE");
                }
                this.hourOfArrival = value;
            }
        }
        public int MinuteOfArrival
        {
            get { return minuteOfArrival; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("MINUTE OF ARRIVAL IS OUT OF RANGE");
                }
                this.minuteOfArrival = value;
            }
        }
        //public Model(int hourOfExam, int minuteOfExam, int hourOfArrival, int minuteOfAriival)
        //{
        //    this.HourOfExam = hourOfExam;
        //    this.MinuteOfExam = minuteOfExam;
        //    this.HourOfArrival = hourOfArrival;
        //    this.MinuteOfArrival = minuteOfArrival;
        //}


        //private bool ISTimeTheSame(bool isTimeSame)
        //{
        //    isTimeSame = false;
        //    if (HourOfExam == HourOfArrival && MinuteOfExam == MinuteOfArrival)
        //    {
        //        isTimeSame = true;

        //    }
        //    return isTimeSame;
        //}
        //private bool ISTimeTheSameButDifferentMinutes(bool isTimeSameButDifferentMinutes)
        //{
        //    isTimeSameButDifferentMinutes = false;
        //    if (HourOfExam == HourOfArrival && (MinuteOfExam > MinuteOfArrival || MinuteOfExam < MinuteOfArrival))
        //    {
        //        isTimeSameButDifferentMinutes = true;
        //    }
        //    return isTimeSameButDifferentMinutes;
        //}
        //private bool IsExamHourNumberBigger(bool examNumberIsBigger)
        //{
        //    examNumberIsBigger = false;
        //    if (HourOfExam > HourOfArrival)
        //    {
        //        examNumberIsBigger = true;
        //    }
        //    return examNumberIsBigger;
        //}
        //private bool IsArrivalHourNumberBigger(bool arrivalHourIsBigger)
        //{
        //    arrivalHourIsBigger = false;
        //    if (hourOfArrival > hourOfExam)
        //    {
        //        arrivalHourIsBigger = true;
        //    }
        //    return arrivalHourIsBigger;
        //}

        public string AreYouOnTimeLateOrEarly()
        {
            string timeMsg = "";
            int minMsg = 0;
            int hourMsg = 0;


            hourMsg = hourOfArrival - hourOfExam;
            minMsg = minuteOfArrival - minuteOfExam;
            if (hourOfArrival > hourOfExam)
            {
                timeMsg = "Late";

                if (minMsg < 0)
                {
                    hourMsg = hourMsg - 1;
                    minMsg = minMsg + 60;
                }

                if (hourMsg <= 0)
                {
                    Message = $"Late\nYou are late with {minMsg} minutes";
                }
                else
                {
                    //int newHour = newRealHour - hourOfExam;
                    Message = $"Late\nYou are late with {hourMsg}:{minMsg} hours";
                }
            }
            else //on
            if (hourOfArrival == hourOfExam)
            {
                timeMsg = "On time";
                minMsg =  minuteOfExam-minuteOfArrival;
                if (minMsg == 0)
                {
                    Message = "On time";
                }
                if (minMsg <= 30)
                {
                    Message = $"On Time\nYou are early with {minMsg} minutes";
                }
            }
            else /// po-rano(hourOfExam > hourOfArrival)
            {
                timeMsg = "Early";
                hourMsg = hourOfExam - hourOfArrival;
                minMsg = minuteOfExam - minuteOfArrival;
                if (minMsg < 0)
                {
                    hourMsg = hourMsg - 1;
                    minMsg = minMsg + 60;
                }

                if (hourMsg <= 0)
                {
                    Message = $"\nYou are early with {minMsg} minutes";
                }
                else
                {
                    Message = $"Early\nYou are early with  {hourMsg}:{minMsg} hours";
                }
            }
            return Message;
        }
    }
}
