namespace TodoList.ViewModel
{
    [QueryProperty("Task", "newTask")]
    [QueryProperty("TaskBank", "TaskBank")]
    public partial class AddTaskViewModel : ObservableObject
    {
        public AddTaskViewModel()
        {
            Statuses = new List<string> { "To do", "Progress", "Review", "Done" };
            Priorities = new List<string> { "Least", "Low", "Medium", "Hard", "Extreme" };
            Categories = new List<string> { "Personal", "Work", "School" };

            Date = DateTime.Now;
            DueDate = DateTime.Now.AddDays(7);
        }

        [ObservableProperty]
        private string taskTitle;
        [ObservableProperty]
        private string taskDescription;
        [ObservableProperty]
        private string taskAssignee;
        [ObservableProperty]
        private string selectedStatus;
        [ObservableProperty]
        private string selectedPriority;
        [ObservableProperty]
        private string selectedCategory;
        [ObservableProperty]
        private DateTime date;
        [ObservableProperty]
        private DateTime dueDate;

        [ObservableProperty]
        private List<string> statuses;
        [ObservableProperty]
        private List<string> priorities;
        [ObservableProperty]
        private List<string> categories;

        [ObservableProperty]
        TaskProperty newTask;
        [ObservableProperty]
        TaskBank taskBank;

        [RelayCommand]
        void AddTask()
        {
            NewTask = new TaskProperty();

            NewTask.Title = TaskTitle;
            NewTask.Description = TaskDescription;
            NewTask.Status = SelectedStatus;
            NewTask.Priority = SelectedPriority;
            NewTask.Assignee = TaskAssignee;
            NewTask.Category = SelectedCategory;
            NewTask.Date = Date;
            NewTask.DueDate = DueDate;

            TaskBank.Tasks.Add(NewTask);

            Application.Current?.MainPage?.DisplayAlert("Success", "Task added successfully", "Okazz");
            Shell.Current.GoToAsync("..");
        }
    }
}
