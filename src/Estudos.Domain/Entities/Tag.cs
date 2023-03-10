using Estudos.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductToDb> Products { get; set; }
        public Tag(string name)
        {
            Name = name;
        }
    }
}
