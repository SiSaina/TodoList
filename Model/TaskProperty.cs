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
        public List<TaskProperty> tasks = new List<TaskProperty>();
        [ObservableProperty]
        public List<string> statuses = ["To do", "Progress", "Review", "Done"];
        [ObservableProperty]
        public List<string> category = ["Personal", "Work", "School"];
        [ObservableProperty]
        public List<string> priorities = ["Least", "Low", "Medium", "Hard", "Extreme"];
    }
}