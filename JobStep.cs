using System;

namespace BatchServiceLibrary
{
  public class JobStep
  {
    public string StepName { get; set; }

    public JobStep(string stepName) => this.StepName = stepName;

    public IItemReader Reader { get; set; }
    public IItemWriter Writer { get; set; }

    //public IItemProcessor Processor { get; set; }

    public void Process() => Console.WriteLine(this.StepName);

  }

  public interface IItemWriter
  {
  }

  public interface IItemReader
  {
  }
}
