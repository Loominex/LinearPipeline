
using LinearPipeline.Console.Contract;
using LinearPipeline.Console.Model;
using LinearPipeline.Console.Services;
using LinearPipeline.Console.Steps;

namespace LinearPipeline.Console
{
   public class PipelineCentre
    {
        private int _insuranceId;
        public PipelineCentre(int insuranceId)
        {
            this._insuranceId = insuranceId;
        }
        public void Start()
        {
            var result = new StepResult() { CurrentInsuranceId = _insuranceId };
            var logService = new DbLogService();
            var pipeline = new BasePipeline<StepResult>(logService);
            //Step1
            pipeline.Register(new Step1()).
            // Step2
            Register(new Step2()).
            // Step3
            Register(new Step3()).
            //Triggering the execution
            //Trigger method only appear when at least Register method called one time!
            Trigger(result);

        }
    }
}
