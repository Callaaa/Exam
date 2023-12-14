using ExamProblem.Models;
using ExamProblem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Controllers
{
    public class ExamActionController
    {
        private Model model = new Model();
        private Display display = new Display();
        public ExamActionController()
        {

           display.Input();
           display.Message=model.AreYouOnTimeLateOrEarly();
           display.Output();


        }
    }
}
