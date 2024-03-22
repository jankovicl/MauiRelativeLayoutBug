namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage(); //= new AppShell();
        }
    }
}
