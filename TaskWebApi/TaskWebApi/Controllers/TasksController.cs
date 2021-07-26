using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWebApi.Repository;

namespace TaskWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITaskRepository _taskRepository;
        public TasksController()
        {
            _taskRepository = new TaskRepositoryData();
        }
        [HttpGet]
        public IActionResult GetTasks()
        {
            var tasks = _taskRepository.GetTasks2();
            return Ok(tasks);
        }


    }
}
