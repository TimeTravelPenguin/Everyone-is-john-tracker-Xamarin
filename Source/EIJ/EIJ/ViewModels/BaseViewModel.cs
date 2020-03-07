using EIJ.Models;
using EIJ.Services;
using EIJ.Types;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  public class BaseViewModel : PropertyChangedBase
  {
    private bool isBusy;

    private string title = string.Empty;
    public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

    public bool IsBusy
    {
      get => isBusy;
      set => SetValue(ref isBusy, value);
    }

    public string Title
    {
      get => title;
      set => SetValue(ref title, value);
    }
  }
}