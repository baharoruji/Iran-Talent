using IranTalent.Domain.Entities.Commons;
using System.Collections.Generic;

namespace IranTalent.Domain.Entities.Users
{
    public class Role: BaseEntity
    {
         public string  Name { get; set; }
         public ICollection<UserInRole > UserInRoles { get; set; }
    }
}
