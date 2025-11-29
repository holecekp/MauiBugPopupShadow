using CommunityToolkit.Maui.Extensions;

namespace MauiBugPopupShadow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPopup(object? sender, EventArgs e)
        {
            Shell.Current.ShowPopup(new SamplePopup());
        }
    }
}
