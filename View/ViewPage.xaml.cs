using TodoList.ViewModel;

namespace TodoList.View;

public partial class ViewPage : ContentPage
{
	public ViewPage(ViewPageViewModel ViewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel;
	}

}