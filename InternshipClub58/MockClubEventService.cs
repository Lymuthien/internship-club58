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
    }
}
