namespace TodoList.Model
{
    public partial class TaskProperty : ObservableObject
    {
        [ObservableProperty]
        public int id;
        [ObservableProperty]
        public string title = "Unknown";
        [ObservableProperty]
        public string description = string.Empty;
        [ObservableProperty]
        public string status = string.Empty;
        [ObservableProperty]
        public string category = string.Empty;
        [ObservableProperty]
        public string assignee = string.Empty;
        [ObservableProperty]
        public DateTime date = DateTime.Now;
        [ObservableProperty]
        public DateTime dueDate;
        [ObservableProperty]
        public string priority = "Medium";
    }
    public partial class TaskBank : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TaskProperty> tasks = [];
        [ObservableProperty]
        private ObservableCollection<string> statuses = ["To do", "Progress", "Review", "Done"];
        [ObservableProperty]
        private ObservableCollection<string> categories = ["Personal", "Work", "School"];
        [ObservableProperty]
        private ObservableCollection<string> priorities = ["Least", "Low", "Medium", "Hard", "Extreme"];

    }
}