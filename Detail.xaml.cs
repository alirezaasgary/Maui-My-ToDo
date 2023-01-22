using My_ToDo.VIewModel;

namespace My_ToDo;

public partial class Detail : ContentPage
{
	public Detail(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}
}