using Microsoft.Maui.Controls.Compatibility;
using VisualElement = Microsoft.Maui.Controls.VisualElement;

namespace MauiApp3
{
    public class LoginPage : ContentPage
    {
        private Button loginButton;

        public LoginPage()
        {
            var layout = new Microsoft.Maui.Controls.Compatibility.RelativeLayout();

            var image = new Image
            {
                StyleId = "LoginLogo",
                VerticalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFit,
                Source = "logo.png"
            };

            loginButton = new Button
            {
                StyleId = "LoginButton",
                TextColor = Colors.White,
                BackgroundColor = Colors.Blue,
                HeightRequest = 40,
                FontSize = 17
            };
            loginButton.SetBinding(VisualElement.BackgroundColorProperty, "LoginButtonColor");
            loginButton.SetBinding(Button.CommandProperty, "Login");
            loginButton.SetBinding(Button.TextProperty, "LoginButtonText");


            var labelHeight = Constraint.RelativeToParent(p => p.Height * 4.2 / 62);
            var labelWidth = Constraint.RelativeToParent(p =>
            {

                return p.Width * .9;
            });

            var labelX = Constraint.RelativeToParent(p =>
            {

                return p.Width * .05;
            });

            layout.Children.Add(image,
                Constraint.RelativeToParent(p => (p.Width - (p.Width * (27.5 - 8) / 36)) / 2),
                Constraint.RelativeToParent(p => p.Height * 3.5 / 62),
                Constraint.RelativeToParent(p => p.Width * (27.5 - 8) / 36),
                Constraint.RelativeToParent(p => p.Height * (26 - 2.5) / 62));

            layout.Children.Add(loginButton,
                labelX,
                Constraint.RelativeToParent(p => p.Height * 51 / 62),
                labelWidth,
                Constraint.RelativeToParent(p => p.Height * 5 / 62));

            this.Content = new ContentView
            {
                StyleId = "LoginContentView",
                Content = new Microsoft.Maui.Controls.ScrollView
                {
                    StyleId = "LoginScrollView",
                    Content = layout
                }
            };

        }
    }
}

