namespace InternshipClub58
{
    public partial class MainPage : ContentPage
    {
        public string EventNames { get; set; }
        public MainPage()
        {
            var service = new MockClubEventService();
            var events = service.GetEvents();
            EventNames = string.Join("\n", events.Select(e => e.Name));

            InitializeComponent();
            BindingContext = this;
        }

    }

}
