using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWebApi.Models;

namespace TaskWebApi.Repository
{
    public class TaskRepositoryData : ITaskRepository
    {
        private List<Tasks> _tasksList;
        private List<Step> _steps;


        public TaskRepositoryData()
        {
            _tasksList = new List<Tasks>()
            {
                new Tasks() {Id=1,Name="Task_1",HasStep=true},
                new Tasks() {Id=2,Name="Task_2",HasStep=true }

            };

            List<Step> _partialSteps = new List<Step>()
            {
                  new Step() {StepId=4,Name="Step_1_2_1",Owner="Joe",TaskId=1,ParentId=2},
                   new Step() {StepId=5,Name="Step_1_2_2",Owner="Joe",TaskId=1,ParentId=2 },
                   new Step() {StepId=8,Name="Step_2_1_1",Owner="Bob & Alice",ParentId=7,TaskId=2 },
                   new Step() {StepId=9,Name="Step_2_1_2",Owner="Bob & Max",TaskId=2,ParentId=7 },
                    new Step() {StepId=6,Name="Step_1_2_1_1",Owner="Joe",TaskId=1,ParentId=4 },
            };
            _steps = new List<Step>()
            {
                new Step() {StepId=1,Name="Step_1_1", Owner="Marcel",TaskId=1},
                new Step() {StepId=2,Name="Step_1_2",Owner="Joe",TaskId=1,steps=_partialSteps.Where(x=>x.ParentId==2).ToList()},
                 new Step() {StepId=3,Name="Step_1_3",Owner="Joe",TaskId=1},

                 

                 new Step() {StepId=7,Name="Step_2_1",Owner="Bob",TaskId=2,steps=_partialSteps.Where(x=>x.ParentId==7).ToList()},
                 new Step() {StepId=10,Name="Step_2_2",Owner="Joe",TaskId=2 },
                new Step() {StepId=11,Name="Step_2_3",Owner="Joe",TaskId=2 },
            };
           
        }
       
            public List<Tasks> GetTasks2()
        {
            _tasksList = new List<Tasks>()
            {
                new Tasks() {Id=1,Name="Task_1",Steps=_steps.Where(x=>x.TaskId==1).ToList(),HasStep=true},
                new Tasks() {Id=2,Name="Task_2",Steps=_steps.Where(x=>x.TaskId==2).ToList(),HasStep=true}

            };

      
            return _tasksList;
        }
      
    }
}
