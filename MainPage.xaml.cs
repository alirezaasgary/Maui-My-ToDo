using My_ToDo.VIewModel;

namespace My_ToDo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext =vm;
	}

}

