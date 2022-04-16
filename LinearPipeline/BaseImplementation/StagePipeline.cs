using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.BaseContract;
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Contract;
using LinearPipeline.Console.Model;
using LinearPipeline.Console.Services.Contract;

namespace LinearPipeline.Console.Implementation
{
    public class StagePipeline<T>: IStagePipeline<T> where T:BaseResult
    {
        private readonly BaseLogService<T> _logService;
        private readonly IBasePipelineRegister<T> pipelineRegister;
        public List<StepBaseBusiness<T>> Steps { get; set; }

        public StagePipeline(BaseLogService<T> logService,IBasePipelineRegister<T> pipelineRegister)
        {           
            _logService = logService;
            this.pipelineRegister = pipelineRegister;
            Steps = pipelineRegister.Steps;
        }


        public IStagePipeline<T> Register(StepBaseBusiness<T> step)
        {
           return pipelineRegister.Register(step);
        }
        //Trigger method only appear when at least Register method called one time!

        public void Trigger(T result)
        {
            foreach (var step in Steps)
            {
                result = step.Execute(result);
                result.CurrentStep = step.CurrentStep;
                _logService.LogResult(result);
                if (!result.IsSuccess)
                {
                    break;
                }

            }
        }


    }
}
