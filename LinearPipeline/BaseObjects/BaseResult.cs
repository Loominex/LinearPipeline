using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.Common;

namespace LinearPipeline.Console.BaseObjects
{
   public class BaseResult
    {
        public bool IsSuccess { get; set; }
        public StepEnum CurrentStep { get; set; }

    }
}
