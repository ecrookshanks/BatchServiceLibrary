using System;

namespace BatchServiceLibrary.Attributes
{
  [AttributeUsage (AttributeTargets.Class)]
  public sealed class BatchNameAttribute : Attribute
  {
    public String Name;

    public BatchNameAttribute(String Name) { this.Name = Name; }

  }
}
