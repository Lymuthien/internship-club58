using Moq;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        public string EventNames { get; set; }
        public MainPage()
        {
            var mock = new Mock<IClubEventService>();
            mock.Setup(s => s.GetClubEvents()).Returns(GetTestEvents());

            var service = new MockClubEventService(mock.Object);
            
            EventNames = service.GetEventNamesAndDescriptions();

            InitializeComponent();
            BindingContext = this;
        }
        private static List<ClubEvent> GetTestEvents()
        {
            var clubEvents = new List<ClubEvent>
            { 
                new() { Id = "1", Name = "Mock Event 1", Description = "Description 1" },
                new() { Id = "2", Name = "Mock Event 2", Description = "Description 2" },
                new() { Id = "3", Name = "Mock Event 3", Description = "Description 3" }
            };
            return clubEvents;
        }

    }

}
