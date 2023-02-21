namespace TGReaderGX;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Read), typeof(Read));
        Routing.RegisterRoute(nameof(LoginSMB), typeof(LoginSMB));
        Routing.RegisterRoute(nameof(SMBListView), typeof(SMBListView));
        Routing.RegisterRoute(nameof(History), typeof(History));
        Routing.RegisterRoute(nameof(SetSMB), typeof(SetSMB));
        Application.Current.UserAppTheme = AppTheme.Light;
    }
}
