namespace TodoList.ViewModel
{
    [QueryProperty("Task","TaskProperty")]
    public partial class ViewPageViewModel : BaseViewModel
    {

        public ViewPageViewModel() 
        {

        }

        [ObservableProperty]
        TaskProperty task;

    }
}
