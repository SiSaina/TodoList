using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using TodoList.ViewModel;

namespace TodoList
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var originalColor = button.BackgroundColor;
                var newColor = Colors.White; // Desired color

                // Animate the button's background color to the new color
                await button.ColorTo(originalColor, newColor, c => button.BackgroundColor = c, 100);

                // Wait for a while
                await Task.Delay(100);

                // Animate the button's background color back to the original color
                await button.ColorTo(newColor, originalColor, c => button.BackgroundColor = c, 100);
            }
        }
    }
}
