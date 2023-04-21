using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR
{
    class GroupHelper
    {
        public static List<Group> GetGroups(string defaultGroup)
        {
            return new List<Group>
            {
                new Group { Id = 0, Name = defaultGroup },
                new Group { Id = 1, Name = "Zatrudniony" },
                new Group { Id = 2, Name = "Zwolniony" }
            };
        }
    }
}
