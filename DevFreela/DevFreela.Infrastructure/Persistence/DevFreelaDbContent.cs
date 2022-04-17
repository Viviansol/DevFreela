using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core", "Minha descrição do projeto ", 1 ,1, 10000),
                new Project("MEu projeto ASPNET Core 2", "Minha descrição do projeto 2", 1 ,1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição do projeto 3", 1 ,1, 30000)
            };

            User = new List<Users>()
            {
                new Users ("Vivan Sanches", "viviansan93@gmail.com", new DateTime(1992,1,1)),
                new Users ("Arthur", "viviansan93@gmail.com", new DateTime(1992,1,1)),
                new Users ("Raissa", "viviansan93@gmail.com", new DateTime(1992,1,1)),
            };

            Skills = new List<Skill>()
            {
                new Skill("C#"),
                new Skill(".Net")
            };
        }
        public List<Project> Projects { get; set; }
        public List<Users> User { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
