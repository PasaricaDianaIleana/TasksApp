using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebApi.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool HasStep { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
