using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Contract;

namespace LinearPipeline.Console.BaseContract
{
   public interface IBasePipelineRegister<T> where T:BaseResult
    {
       IStagePipeline<T> Register(StepBaseBusiness<T> step);
       List<StepBaseBusiness<T>> Steps { get; set; }
    }
}
