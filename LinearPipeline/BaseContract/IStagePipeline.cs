using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Contract;

namespace LinearPipeline.Console.BaseContract
{
   public interface IStagePipeline<T>: IBasePipelineTrigger<T>,IBasePipelineRegister<T> where T:BaseResult 
    {
    }
}
