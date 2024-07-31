

namespace TodoList.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            Statuses = new ObservableCollection<string> { "To do", "Progress", "Review", "Done" };
            Priorities = new ObservableCollection<string> { "Least", "Low", "Medium", "Hard", "Extreme" };
            Categories = new ObservableCollection<string> { "Personal", "Work", "School" };

            taskBank = new TaskBank();

            // Initialize the Tasks collection and add it to the TaskBank
            Tasks = new ObservableCollection<TaskProperty>
            {
                new TaskProperty
                {
                    Title = "Default Task",
                    Description = "This is a default task.",
                    Status = "To do",
                    Priority = "Medium",
                    Assignee = "Unassigned",
                    Category = "Personal",
                    Date = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7)
                }
            };
        }


        [ObservableProperty]
        ObservableCollection<string> statuses;
        [ObservableProperty]
        ObservableCollection<string> priorities;
        [ObservableProperty]
        ObservableCollection<string> categories;
        [ObservableProperty]
        ObservableCollection<TaskProperty> tasks;

        [ObservableProperty]
        TaskBank taskBank;

        [RelayCommand]
        void AddTask()
        {
            Shell.Current.GoToAsync(nameof(AddTaskPage), new Dictionary<string, object>
            {
                {"TaskBank", TaskBank }
            });
        }
    }
}