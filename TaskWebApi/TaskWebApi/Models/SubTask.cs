using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebApi.Models
{
    public class SubTask
    {

        public int SubTaskId { get; set; }
        public string SubTaskName { get; set; }
        public string Name { get; set; }
        public int StepId { get; set; }
    }
}
