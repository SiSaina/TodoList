using TodoList.ViewModel;

namespace TodoList.View;

public partial class ModifyPage : ContentPage
{
    public ModifyPage(ModifyPageViewModel ViewModel)
    {
        InitializeComponent();
        BindingContext = ViewModel;
    }
}