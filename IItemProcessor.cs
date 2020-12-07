

namespace BatchServiceLibrary
{
  public interface IItemProcessor<in Tin, out Tout>
  {
    Tout ProcessItem(Tin item);
  }
}
