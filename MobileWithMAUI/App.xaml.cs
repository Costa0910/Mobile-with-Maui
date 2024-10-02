namespace MobileWithMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var navPage = new NavigationPage(new MyPage())
            {
                BarBackgroundColor = Colors.Yellow,
                BarTextColor = Colors.Blue
            };
        MainPage = new TabbedPageDemo();
    }
}
