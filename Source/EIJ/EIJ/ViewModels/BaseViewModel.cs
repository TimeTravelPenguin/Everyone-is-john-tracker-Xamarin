using EIJ.Models;
using EIJ.Services;
using EIJ.Types;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  public class BaseViewModel : PropertyChangedBase
  {
    private bool _isBusy;

    private string _title = string.Empty;
    public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

    public bool IsBusy
    {
      get => _isBusy;
      set => SetValue(ref _isBusy, value);
    }

    public string Title
    {
      get => _title;
      set => SetValue(ref _title, value);
    }
  }
}