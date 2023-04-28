using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    public class Entity
    {
        public int Id { get; set; }

        [DisallowNull]
        public string Name { get; set; }

        [DisallowNull]
        public string Description { get; set; }

        [DisallowNull]
        public string Type { get; set; }
    }
}
