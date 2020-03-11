using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  public class RulesViewModel : BaseViewModel
  {
    private static readonly Uri RulebookUri = new Uri(@"https://rulebook.io/games/everyone-is-john/rules/");

    public ICommand OpenWebCommand { get; }

    public RulesViewModel()
    {
      Title = "Rules";

#pragma warning disable CA2007 // Consider calling ConfigureAwait on the awaited task
      OpenWebCommand = new Command(async () => await Browser.OpenAsync(RulebookUri));
#pragma warning restore CA2007 // Consider calling ConfigureAwait on the awaited task
    }
  }
}