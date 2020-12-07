using Microsoft.Extensions.Hosting;
using System;

namespace BatchServiceLibrary.Builders
{
  public class BatchJobBuilder
  {

    public String Batchname { get; set; }
    public String JobName { get; set; }
    public IHost Host { get; set; }


    protected BatchJobBuilder(String batchName)
    {
      this.Batchname = batchName;
    }

    public static BatchJobBuilder CreateBatch(String BatchName)
    {
      BatchJobBuilder bjb = new BatchJobBuilder(BatchName);
      return bjb;
    }
    
    public BatchJobBuilder AddHost(IHost host)
    {
      this.Host = host;
      return this;
    }

    public BatchJobBuilder AddJob(String jobName)
    {
      this.JobName = jobName;
      return this;
    }

    public BatchJobHost Build()
    {
      BatchJobHost job = new BatchJobHost
      {
        Host = Host,
        JobName = JobName
      };

      return job;
    }




  }
}
