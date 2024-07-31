using TodoList.ViewModel;

namespace TodoList.View;
public partial class AddTaskPage : ContentPage
{
	public AddTaskPage(AddTaskViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}