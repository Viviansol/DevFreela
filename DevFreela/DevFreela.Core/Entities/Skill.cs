using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities
{
   public  class Skill : BaseEntity
    {
        public Skill(String description)
        {
            Description = description;
            CreatedAdt = DateTime.Now;
        }
        public string Description { get; private set; }
        public DateTime CreatedAdt { get; private set; }
    }
}
