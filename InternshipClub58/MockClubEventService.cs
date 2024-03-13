using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace InternshipClub58
{
    public class MockClubEventService : IClubEventService
    {
        public List<Event> GetEvents()
        {
            var mockEvents = new List<Event>
            {
                new() { Id = 1, Name = "Mock Event 1" },
                new() { Id = 2, Name = "Mock Event 2" }
            };

            var mockService = new Mock<IClubEventService>();
            mockService.Setup(s => s.GetEvents()).Returns(mockEvents);

            return mockService.Object.GetEvents();
        }
    }
}
