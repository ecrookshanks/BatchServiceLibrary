using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BatchServiceLibrary
{
  public abstract class BatchJobService : BackgroundService
  {
    public AutoResetEvent CompleteEvent { get; private set; }

    protected List<JobStep> Steps;

    public void AddStep(JobStep step) => this.Steps.Add(step);

    protected BatchJobService()
    {
      this.CompleteEvent = new AutoResetEvent(false);
    }
    

    protected void CompleteBatch() =>  this.CompleteEvent.Set();

    public virtual void SetUpSteps()
    {
      Steps = new List<JobStep>();
    }

    public virtual async Task Process()
    {
      if (Steps == null || Steps.Count == 0)
      {
        return;
      }

      foreach (var item in Steps)
      {
        item.Process();
      }
    }

  }
}
