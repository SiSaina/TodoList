namespace TodoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ViewPage), typeof(ViewPage));
            Routing.RegisterRoute(nameof(ModifyPage), typeof(ModifyPage));
        }
    }
}
