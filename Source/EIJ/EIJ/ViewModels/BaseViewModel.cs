using EIJ.Types;

namespace EIJ.ViewModels
{
  public class BaseViewModel : PropertyChangedBase
  {
    private string _title = string.Empty;

    public string Title
    {
      get => _title;
      set => SetValue(ref _title, value);
    }
  }
}