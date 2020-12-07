using BatchServiceLibrary.Utils;
using Microsoft.Extensions.Hosting;
using System;

namespace BatchServiceLibrary
{
  public class BatchJobHost
  {
    public IHost Host { get; set; }
    public String JobName { get; set; }
    public void Run()
    {
      Host.RunBatch(JobName);
    }
  }
}
