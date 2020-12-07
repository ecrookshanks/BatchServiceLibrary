

namespace BatchServiceLibrary.Builders
{
  public class StepBuilder
  {
    private JobStep step;
    public StepBuilder()
    { }

    public StepBuilder NewStep(string stepName)
    {
      step = new JobStep(stepName);
      return this;
    }

    public JobStep Build() => step;


  }
}
