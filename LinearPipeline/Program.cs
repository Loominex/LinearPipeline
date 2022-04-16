using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearPipeline.Console.Model;

namespace LinearPipeline.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var recordIds = new int[] { };//this array could be fetch from db or any other resource.
            //you can also pass the exact record or any type of parameter based on your business.
            foreach (var recordId in recordIds)
            {
                var pipeline = new PipelineCentre(recordId);
                pipeline.Start();
            }

        }
    }
}
