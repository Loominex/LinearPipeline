using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Common;

namespace LinearPipeline.Console.Model
{
   public class StepResult:BaseResult
    {
        public StepResult()
        {
            this.ErrorList = new Dictionary<string, string>();
        }
        public int CurrentInsuranceId { get; set; }
        public Dictionary<string,string> ErrorList { get; set; }
        public string ResultString { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public bool IsException  { get; set; }
    }
}
