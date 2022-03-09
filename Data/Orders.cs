using Chushka1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPChushka1.Data
{
    public class Orders
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public virtual Products Product { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
