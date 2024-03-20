using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp
{
    public interface IClubEventService
    {
        List<ClubEvent> GetClubEvents();
        ClubEvent GetClubEvent(int id);
        void Create(ClubEvent clubEvent);
    }
}
