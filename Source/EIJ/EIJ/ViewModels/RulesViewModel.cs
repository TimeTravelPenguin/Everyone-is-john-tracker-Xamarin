using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  public class RulesViewModel : BaseViewModel
  {
    public ICommand OpenWebCommand { get; }

    public RulesViewModel()
    {
      Title = "Rules";
      OpenWebCommand = new Command(async () => await Browser.OpenAsync(@"https://rulebook.io/games/everyone-is-john/rules/"));
    }
  }
}