using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureCom.Entities
{
    public class OgretmenKurs
    {
        public int Id { get; set; }
        public int OgretmenId { get; set; }
        public int KursId { get; set; }
    }
}
