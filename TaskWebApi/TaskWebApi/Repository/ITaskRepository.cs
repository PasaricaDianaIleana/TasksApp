using System;
using System.Collections.Generic;
using System.Linq;
using TaskWebApi.Models;


namespace TaskWebApi.Repository
{
   public interface ITaskRepository
    {
      
        List<Tasks> GetTasks2();

       // List<Step> GetStepByTaskId(int id);
    }
}
