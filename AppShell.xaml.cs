namespace My_ToDo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Detail), typeof(Detail));
	}
}
