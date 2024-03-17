using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace InternshipClub58
{
    public class MockClubEventService(IClubEventService r)
    {
        readonly IClubEventService repo = r;

        public int CountOfEvents()
        {
            return repo.GetClubEvents().Count;
        }
        public List<string?> GetClubEventNames() 
        {
            var clubEvents = repo.GetClubEvents();

            var clubEventNames = clubEvents.Select(e => e.Name).ToList();
            return clubEventNames;
        }
        public List<string?> GetClubEventDescriptions() 
        {
            var clubEvents = repo.GetClubEvents();
            var clubEventDescriptions = clubEvents.Select(e => e.Description).ToList();
            return clubEventDescriptions;
        }
        
        /*
        public List<ClubEvent> GetEvents()
        {
            var mock = new Mock<IClubEventService>();
            mock.Setup(s => s.GetEvents()).Returns(GetTestEvents());

            return mock.Object.GetEvents();
        }
        private static List<ClubEvent> GetTestEvents()
        {
            var clubEvents = new List<ClubEvent>
            { 
                new() { Id = "1", Name = "Mock Event 1" },
                new() { Id = "2", Name = "Mock Event 2" },
                new() { Id = "3", Name = "Mock Event 3"}
            };
            return clubEvents;
        }*/

        
    }
}
