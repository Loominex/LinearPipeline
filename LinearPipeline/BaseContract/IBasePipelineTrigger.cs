using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseObjects;

namespace LinearPipeline.Console.BaseContract
{
   public interface IBasePipelineTrigger<T> where T:BaseResult
    {
        //Trigger method only appear when at least Register method called one time!
        void Trigger(T result);
    }
}
