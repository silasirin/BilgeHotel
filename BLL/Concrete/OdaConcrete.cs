using BLL.Repository;
using DAL.Entity;
using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class OdaConcrete:BaseRepository<Oda>
    {
        public OdaDurumu OdaDurumu { get; set; }

    }
}
