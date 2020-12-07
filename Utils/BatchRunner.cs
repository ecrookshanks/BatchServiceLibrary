using Microsoft.Extensions.Hosting;
using System;

namespace BatchServiceLibrary.Utils
{

  //
  // Extention method for the IHost interfaces.  Provides for running the batch
  // service via the host.  This method is necessary to wait for the completion
  // event.  The batch service uses this event to signal when it is complete and
  // for the host to stop.
  //
  public static class BatchRunner
  {
    public static void RunBatch(this IHost host, string theName)
    {
      host.StartAsync();

      var hostedWorker = host.FindBatchByName(theName) as BatchJobService;
      hostedWorker.CompleteEvent.WaitOne();

      host.StopAsync();
      host.Dispose();
    }
  }
}
