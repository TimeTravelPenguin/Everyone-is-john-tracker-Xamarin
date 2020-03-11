using System.Collections.ObjectModel;
using EIJ.Models;

namespace EIJ.ViewModels
{
  internal class VoicesViewModel : BaseViewModel
  {
    public ObservableCollection<VoiceModel> Voices { get; }

    public VoicesViewModel()
    {
      Title = "Voices";
      Voices = new ObservableCollection<VoiceModel>
      {
        new VoiceModel {PlayerName = "Phillip"},
        new VoiceModel {PlayerName = "Caitlin"},
        new VoiceModel {PlayerName = "Kyra"}
      };
    }

    public VoicesViewModel(ObservableCollection<VoiceModel> voices)
    {
      Voices = voices;
    }
  }
}