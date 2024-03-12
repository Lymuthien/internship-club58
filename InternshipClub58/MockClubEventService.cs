using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipClub58
{
    public class MockClubEventService : IClubEventService
    {
        public List<Event> GetEvents()
        {
            return new List<Event>
            {
            new Event { Id = 1, Name = "Event 1" },
            new Event { Id = 2, Name = "Event 2" }
            };
        }
    }
}
