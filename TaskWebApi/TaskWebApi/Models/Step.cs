using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWebApi.Models
{
    public class Step
    {

        public int StepId { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public int TaskId { get; set; }
        public int ParentId { get; set; }
        public List<Step>? steps{get;set;}

   
    }
}
