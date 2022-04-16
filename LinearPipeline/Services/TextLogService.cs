using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LinearPipeline.Console.Contract;
using LinearPipeline.Console.Model;
using LinearPipeline.Console.Services.Contract;

namespace LinearPipeline.Console.Services
{
    public class TextLogService : BaseLogService<StepResult>
    {
        private Exception _dbLogException { get; set; }
        public TextLogService(Exception ex)
        {
            this._dbLogException = ex;
        }
        public override void LogResult(StepResult stepResult)
        {
                _TxtLogSeparator = string.IsNullOrEmpty(_TxtLogSeparator) ? "|B|" : _TxtLogSeparator;
                try
                {
                    string filePaph = string.Concat(_RootPath, _FileName);
                    if (!Directory.Exists(_RootPath))
                    {
                        Directory.CreateDirectory(_RootPath);
                    }
                    if (!File.Exists(filePaph))
                    {
                        File.Create(filePaph).Close();
                    }
                    using (var writer = new StreamWriter(filePaph, true))
                    {
                        var regex = new Regex("[\n\r]");
                        StringBuilder builder = new StringBuilder();
                        builder.Append(stepResult.CurrentInsuranceId);
                        builder.Append(_TxtLogSeparator);
                        builder.Append(stepResult.CurrentStep.ToString());
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(stepResult.Message ?? "", ""));
                        builder.Append(_TxtLogSeparator);
                        builder.Append(stepResult.IsSuccess);
                        builder.Append(_TxtLogSeparator);
                        builder.Append(stepResult.IsException);
                        builder.Append(_TxtLogSeparator);
                        builder.Append(GlobalObject.Executiond);
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(stepResult.ResultString ?? "", ""));
                        builder.Append(_TxtLogSeparator);
                        builder.Append(stepResult.Description);
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(stepResult.Description ?? "", ""));
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(JsonConvert.SerializeObject(stepResult.ErrorList) ?? "", ""));
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(JsonConvert.SerializeObject(_dbLogException) ?? "", ""));
                        builder.Append(_TxtLogSeparator);
                        builder.Append(regex.Replace(DateTime.Now.ToLongDateString() ?? "", ""));

                    writer.WriteLine(builder);
                    }
                }

                catch (Exception ex)
                {

                }
            }
        
    }
}
