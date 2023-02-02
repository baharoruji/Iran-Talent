using IranTalent.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IranTalent.Domain.Entities.Jobs
{
    public class JobImage : BaseEntity
    {
        public virtual Job job { get; set; }
        public long JobId { get; set; }
        public string Src { get; set; }
    }
}
