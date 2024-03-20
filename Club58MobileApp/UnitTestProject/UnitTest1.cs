using Moq;
using MobileApp;

namespace UnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void ClubEventServiceTest1()
        {
            static List<ClubEvent> GetTestEvents()
            {
                return
                [
                    new() { Id = "1", Name = "Mock Event 1", Description = "Description 1" },
                    new() { Id = "2", Name = "Mock Event 2", Description = "Description 2" }
                ];
            }

            var mock = new Mock<IClubEventService>();
            mock.Setup(s => s.GetClubEvents()).Returns(GetTestEvents());

            var service = new MockClubEventService(mock.Object);
            var clubEventNames = service.GetClubEventNames();
            var clubEventDescriptions = service.GetClubEventDescriptions();

            Assert.IsType<List<string>>(clubEventNames);
            Assert.IsType<List<string>>(clubEventDescriptions);
            Assert.Equal(2, service.CountOfEvents());
            Assert.Equal("Mock Event 1, Description 1\n" +
                "Mock Event 2, Description 2", service.GetEventNamesAndDescriptions());
        }

        [Fact]
        public void ClubEventServiceTest2()
        {
            static List<ClubEvent> GetTestEvents()
            {
                return
                [
                    new() { Id = null, Name = null, Description = null },
                    new() { Id = null, Name = null, Description = null }
                ];
            }

            var mock = new Mock<IClubEventService>();
            mock.Setup(s => s.GetClubEvents()).Returns(GetTestEvents());

            var service = new MockClubEventService(mock.Object);
            var clubEventNames = service.GetClubEventNames();
            var clubEventDescriptions = service.GetClubEventDescriptions();

            Assert.IsType<List<string?>>(clubEventNames);
            Assert.IsType<List<string?>>(clubEventDescriptions);
            Assert.Equal(2, service.CountOfEvents());
            Assert.Equal(", \n, ", service.GetEventNamesAndDescriptions());
        }
        
    }
}