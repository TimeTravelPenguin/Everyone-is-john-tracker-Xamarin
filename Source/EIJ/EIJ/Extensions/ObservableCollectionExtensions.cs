using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EIJ.Extensions
{
  internal static class ObservableCollectionExtensions
  {
    public static void AddRange<T>(this ObservableCollection<T> thisCollection, IEnumerable<T> itemsToAdd)
    {
      foreach (var item in itemsToAdd)
      {
        thisCollection.Add(item);
      }
    }
  }
}