using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Maui.Views;

namespace MauiBugPopupShadow
{
    public class SamplePopup: Popup
    {
     public SamplePopup()
        {
            Content = new VerticalStackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label { Text = "This is a sample popup." }
                }
            };
        }
    }
}
