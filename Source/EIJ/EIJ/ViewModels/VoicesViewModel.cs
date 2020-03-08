using System.Collections.ObjectModel;
using EIJ.Models;
using Xamarin.Forms;

namespace EIJ.ViewModels
{
  internal class VoicesViewModel : BaseViewModel
  {
    public ObservableCollection<VoiceModel> Voices { get; }
    public Command OnItemSelected { get; }

    public VoicesViewModel()
    {
      Title = "Voices";
      Voices = new ObservableCollection<VoiceModel>();

      OnItemSelected = new Command((s, a) => ItemSelected(s, a));

      Voices.Add(new VoiceModel {PlayerName = "Phillip"});
    }

    public VoicesViewModel(ObservableCollection<VoiceModel> voices)
    {
      Voices = voices;
    }

    private void ItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
      Application.Current.MainPage.DisplayAlert("Ping", "Pong", "Ok");
    }
  }
}