using System;
using System.Collections.Generic;
using LinearPipeline.Console.BaseContract;
using LinearPipeline.Console.Implementation;
using LinearPipeline.Console.BaseObjects;

using LinearPipeline.Console.Services.Contract;

namespace LinearPipeline.Console.Contract
{
   public class BasePipeline<TResult> : IBasePipelineRegister<TResult> where TResult : BaseResult,new()
    {
        public List<StepBaseBusiness<TResult>> Steps { get ; set ; }
        private readonly BaseLogService<TResult> _logService;
        private IStagePipeline<TResult> _stagePipeline;
        public BasePipeline(BaseLogService<TResult> logService)
        {
            this.Steps = new List<StepBaseBusiness<TResult>>();
            this._logService = logService;
            this._stagePipeline = new StagePipeline<TResult>(_logService, this);
        }
        public IStagePipeline<TResult> Register(StepBaseBusiness<TResult> step)
        {
            Steps.Add(step);
            return _stagePipeline;

        }
    }
}
