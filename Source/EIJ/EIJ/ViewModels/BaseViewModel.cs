using EIJ.Types;

namespace EIJ.ViewModels
{
  public class BaseViewModel : PropertyChangedBase
  {
    private bool _isBusy;

    private string _title = string.Empty;

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