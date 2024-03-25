using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Studnt_exam.Models
{
    public class ContentPercentageModel
    {
        public string ContentName { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectQuestions { get; set; }
        public double Percentage { get; set; }
    }
}