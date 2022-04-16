using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Common;

namespace LinearPipeline.Console.Contract
{
    public abstract class StepBaseBusiness<TResult> where TResult : BaseResult
    {
        public abstract StepEnum CurrentStep { get; }
        public abstract TResult Execute(TResult input);

    }
}
