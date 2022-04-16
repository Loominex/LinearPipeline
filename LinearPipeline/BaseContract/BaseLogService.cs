
using LinearPipeline.Console.BaseObjects;
using LinearPipeline.Console.Contract;


namespace LinearPipeline.Console.Services.Contract
{
   public abstract class BaseLogService<T>: BaseLog where T:BaseResult
    {
        public abstract void LogResult(T stepResult);
    }
}
