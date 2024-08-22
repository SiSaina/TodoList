namespace TodoList.ViewModel
{
    [QueryProperty("Task", "TaskProperty")]
    public partial class ModifyPageViewModel : BaseViewModel
    {
        public ModifyPageViewModel() { }

        [ObservableProperty]
        TaskProperty task;
    }
}
