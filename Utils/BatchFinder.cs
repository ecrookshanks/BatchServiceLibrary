using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BatchServiceLibrary.Attributes;

namespace BatchServiceLibrary.Utils
{
  public static class BatchFinder
  {
    //
    // This class provides an extenstion method on the IHost interface to allow for 
    // looking up the the batch names in the host's hosted services collection.  It
    // returns this object as an IHostedService and is used by the batch runner to
    // find the host for which it needs to wait on the completion event.
    //
    public static IHostedService FindBatchByName(this IHost host, string BatchName)
    {
      var hostedServices = host.Services.GetServices<IHostedService>();

      foreach (var item in hostedServices)
      {
        object[] attrs = item.GetType().GetCustomAttributes(false);
      
        foreach (var t in attrs)
        {
          if (t is BatchNameAttribute ban)
          {
            if (ban.Name == BatchName)
            {
              return item;
            }
          }
        }
      }

      return null;
    }
  }
}
