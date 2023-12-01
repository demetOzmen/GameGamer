using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Player: IEntity
    {
        public int id { get; set; }
        public string IdentityNo { get; set; }
        public string Name { get; set; }
        public int DateYear { get; set; }
        public List<Game> PurchasedGames { get; set; }

    }
}
