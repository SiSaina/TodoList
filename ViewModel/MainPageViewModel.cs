namespace TodoList.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            taskBank = new TaskBank();
            
            Tasks = new ObservableCollection<TaskProperty>();
            Date = DateTime.Now;
            DueDate = DateTime.Now.AddDays(7);

            IsMainPage = true;
            IsAddTaskPage = false;
            IsViewPage = false;
        }

        [ObservableProperty]
        bool isMainPage;
        [ObservableProperty]
        bool isAddTaskPage;
        [ObservableProperty]
        bool isViewPage;

        [ObservableProperty]
        ObservableCollection<TaskProperty> tasks;

        static int index = 0;

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
        TaskProperty newTask;

        [ObservableProperty]
        TaskBank taskBank;

        [RelayCommand]
        void AddTask()
        {
            if (string.IsNullOrWhiteSpace(TaskTitle))
            {
                Application.Current?.MainPage?.DisplayAlert("Error", "Please enter a title for the task.", "OK");
                return;
            }

            index++;
            NewTask = new TaskProperty
            {
                Id = index,
                Title = TaskTitle,
                Description = TaskDescription,
                Status = SelectedStatus,
                Priority = SelectedPriority,
                Assignee = TaskAssignee,
                Category = SelectedCategory,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7)
            };

            TaskBank.Tasks.Add(NewTask);

            Tasks.Add(NewTask);

            TaskTitle = string.Empty;
            TaskDescription = string.Empty;
            SelectedStatus = string.Empty;
            SelectedPriority = string.Empty;
            TaskAssignee = string.Empty;
            SelectedCategory = string.Empty;
            DueDate = DateTime.Now.AddDays(7);

            IsMainPage = true;
            IsAddTaskPage = false;
        }
        [RelayCommand]
        void DeleteTask(int id)
        {
            var n = Tasks.FirstOrDefault(t => t.Id == id);
            if (n != null)
            {
                Tasks.Remove(n);
            }
        }

        [RelayCommand]
        void GotoAddPage()
        {
            IsMainPage = false;
            IsAddTaskPage = true;
        }
        [RelayCommand]
        void GotoViewPage(int id)
        {
            TaskProperty? task = Tasks.FirstOrDefault(task => task.Id == id);

            if(task != null)
            {
                Shell.Current.GoToAsync(nameof(ViewPage), new Dictionary<string, object>
                {
                    {"TaskProperty", task }
                });
            }
        }
        [RelayCommand]
        void GotoModifyPage(int id)
        {
            TaskProperty? task = Tasks.FirstOrDefault(task => task.Id == id);

            if (task != null)
            {
                Shell.Current.GoToAsync(nameof(ModifyPage), new Dictionary<string, object>
                {
                    {"TaskProperty", task }
                });
            }
        }
        [RelayCommand]
        void GoBack()
        {
            TaskTitle = string.Empty;
            TaskDescription = string.Empty;
            SelectedStatus = string.Empty;
            SelectedPriority = string.Empty;
            TaskAssignee = string.Empty;
            SelectedCategory = string.Empty;
            Date = DateTime.Now;
            DueDate = DateTime.Now.AddDays(7);

            IsMainPage = true;
            IsAddTaskPage = false;
        }
    }
}