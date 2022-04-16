using System;
using LinearPipeline.Console.Model;
using LinearPipeline.Console.Services.Contract;

namespace LinearPipeline.Console.Services
{
    public class DbLogService : BaseLogService<StepResult>
    {
        public override void LogResult(StepResult stepResult)
        {
            //CargoInsuranceEntities context = null;
            try
            {
                //logging into the database

            }
            catch(Exception ex)
            {
                new TextLogService(ex).LogResult(stepResult);
            }
            finally
            {
                //context?.Dispose();
            }
        }
    }
}
