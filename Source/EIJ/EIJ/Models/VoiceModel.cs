using EIJ.Types;

namespace EIJ.Models
{
  internal class VoiceModel : PropertyChangedBase
  {
    private string _playerName;

    public string PlayerName
    {
      get => _playerName;
      set => SetValue(ref _playerName, value);
    }
  }
}