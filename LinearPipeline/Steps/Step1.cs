
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.Common;
using LinearPipeline.Console.Contract;
using LinearPipeline.Console.Model;

namespace LinearPipeline.Console.Steps
{
    public class Step1 : StepBaseBusiness<StepResult>
    {
        public override StepEnum CurrentStep => StepEnum.RegisterCertificateCode;

        public override StepResult Execute(StepResult input)
        {
            var result = new StepResult() { IsSuccess=true,CurrentInsuranceId = input.CurrentInsuranceId };
            try
            {
                //Your business for 'Step1' goes here.

            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Description = JsonConvert.SerializeObject(ex);
                result.Message = ex.Message;
                result.IsException = true;
            }
            finally
            {
            }
            return result;
        }
    }
}
