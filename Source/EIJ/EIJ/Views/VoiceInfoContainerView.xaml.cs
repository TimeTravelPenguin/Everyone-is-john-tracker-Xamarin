using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EIJ.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class VoiceInfoContainerView : Grid
  {
    public static readonly BindableProperty PlayerNameProperty = BindableProperty.Create(nameof(PlayerName),
      typeof(string), typeof(VoiceInfoContainerView), default(string), propertyChanged: OnPlayerNamePropertyChanged);

    public string PlayerName
    {
      get => (string) GetValue(PlayerNameProperty);
      set => SetValue(PlayerNameProperty, value);
    }

    public VoiceInfoContainerView()
    {
      InitializeComponent();
    }

    private static void OnPlayerNamePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
      SetProperty<string>(bindable, newValue,
        (view, viewValue) => { view.PlayerNameLabel.Text = viewValue; });
    }

    private static void SetProperty<TPropertyType>(BindableObject bindable, object newValue,
      Action<VoiceInfoContainerView, TPropertyType> propertyAssigner)
    {
      if (!(bindable is VoiceInfoContainerView view) || !(newValue is TPropertyType propertyValue))
      {
        throw new InvalidOperationException();
      }

      propertyAssigner.Invoke(view, propertyValue);
    }
  }
}