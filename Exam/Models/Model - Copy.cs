using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExamProblem.Models
{
    public class Model1
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

            if (hourOfArrival > hourOfExam)
            {                
                int minutesLate = minuteOfArrival - minuteOfExam;
                if (minutesLate < 0)
                {
                    int newRealHour = hourOfArrival - 1;
                    int realMinutesLate = minutesLate + 60;

                    if (newRealHour == hourOfExam)
                    {
                        Message = $"Late\nYou are late with {realMinutesLate} minutes";
                    }
                    else
                    {
                        int newHour = newRealHour - hourOfExam;
                        Message = $"Late\nYou are late with {newHour}:{realMinutesLate} hours";
                    }
                }
                else
                {
                    int hoursLate = hourOfArrival - hourOfExam;
                    Message = $"You are late with {hoursLate}:{minutesLate} hours";
                }
            }
            else if (hourOfArrival == hourOfExam && minuteOfArrival == minuteOfExam)
            {
                Message = "On time";
            }
            else
            if (hourOfArrival == hourOfExam)
            {
                if (minuteOfArrival >= minuteOfExam)
                {
                    int minutesLate = minuteOfArrival - minuteOfExam;


                    Message = $"Late\nYou are late with {minutesLate} minutes";
                }
                else
                {
                    int minutesEarly = minuteOfExam - minuteOfArrival;
                    if (minutesEarly <= 30)
                    {
                        Message = $"On time\nYou are early with {minutesEarly} minutes";
                    }
                }
            }
            else
            if (hourOfExam > hourOfArrival)
            {
                int minutesEarly = minuteOfExam - minuteOfArrival;
                if (minutesEarly < 0)
                {
                    int newRealHour = hourOfExam - 1;
                    int realMinutesEarly = minutesEarly + 60;

                    if (newRealHour == hourOfArrival)
                    {
                        if (realMinutesEarly <= 30)
                        {
                            Message = $"On time\nYou are early with {realMinutesEarly} minutes";
                        }
                        if (realMinutesEarly>30)
                        {                      
                            Message = $"Early\nYou are early with {realMinutesEarly} minutes";
                        }                      
                    }
                    else
                    {
                        int newHour = newRealHour - hourOfArrival;
                        Message = $"Early\nYou are early with {newHour}:{realMinutesEarly} hours";
                    }
                }
                else
                {
                    int hoursEarly = hourOfExam - hourOfArrival;
                    Message = $"Early\nYou are early with {hoursEarly}:{minutesEarly} hours";
                }
            }


            //if (ISTimeTheSame(true))
            //{
            //    Message= "On time";
            //}
            //else
            //if (ISTimeTheSameButDifferentMinutes(true))
            //{
            //    if (minuteOfArrival > minuteOfExam)
            //    {
            //        int minutesLate = minuteOfArrival - minuteOfExam;
            //        Message= $"You are late with {minutesLate} minutes";                
            //    }
            //    else
            //    {
            //        int minutesEarly = minuteOfExam - minuteOfArrival;
            //        Message = $"You are early with {minutesEarly} minutes";                
            //    }
            //}
            //else
            //if (IsExamHourNumberBigger(true))
            //{
            //    int minutesEarly = minuteOfExam - minuteOfArrival;
            //    if (minutesEarly < 0)
            //    {
            //        int newRealHour = hourOfExam - 1;
            //        int realMinutesEarly = minutesEarly + 60;

            //        if (newRealHour == hourOfArrival)
            //        {
            //            Message= $"You are early with {realMinutesEarly} minutes";                      
            //        }
            //        else
            //        {
            //            int newHour = newRealHour - HourOfArrival;
            //            Message = $"You are early with {newHour}:{realMinutesEarly} hours";
            //        }
            //    }
            //    else
            //    {
            //        int hoursEarly = hourOfExam - hourOfArrival;
            //        Message= $"You are early with {hoursEarly}:{minutesEarly} hours";                 
            //    }
            //}
            //else
            //if (IsArrivalHourNumberBigger(true))
            //{
            //    int minutesLate = minuteOfArrival - minuteOfExam;
            //    if (minutesLate < 0)
            //    {
            //        int newRealHour = hourOfArrival - 1;
            //        int realMinutesLate = minutesLate + 60;

            //        if (newRealHour == hourOfExam)
            //        {
            //          Message = $"You are late with {realMinutesLate} minutes";                       
            //        }
            //        else
            //        {
            //            int newHour = newRealHour - hourOfExam;
            //            Message = $"You are late with {newHour}:{realMinutesLate} hours";

            //        }
            //    }
            //    else
            //    {
            //        int hoursLate = hourOfArrival - hourOfExam;
            //       Message = $"You are late with {hoursLate}:{minutesLate} hours";                  
            //    }


            return Message;
        }
    }
}
