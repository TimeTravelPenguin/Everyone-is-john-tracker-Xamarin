using System;
using System.Windows.Input;
using EIJ.Models;
using Xamarin.Forms;

namespace EIJ.Behaviors
{
  internal class ItemTappedBehavior : Behavior<ListView>
  {
    public static readonly BindableProperty CommandProperty = BindableProperty
      .CreateAttached("Command",
        typeof(ICommand),
        typeof(ListView),
        null);

    protected override void OnAttachedTo(ListView bindable)
    {
      bindable.ItemTapped += OnItemTapped;
      base.OnAttachedTo(bindable);
    }

    protected override void OnDetachingFrom(ListView bindable)
    {
      bindable.ItemTapped -= OnItemTapped;
      base.OnDetachingFrom(bindable);
    }

    private static void OnItemTapped(object sender, ItemTappedEventArgs args)
    {
      if (!(sender is ListView view))
      {
        throw new InvalidOperationException();
      }

      var selected = (VoiceModel) view.SelectedItem;

      // Do something
      Application.Current.MainPage.DisplayAlert("Tap Alert!", $"Name: {selected.PlayerName}", "Ok");
    }
  }
}