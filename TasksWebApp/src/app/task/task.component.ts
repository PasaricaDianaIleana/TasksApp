import { Component, OnInit } from '@angular/core';
import { TaskService } from '../Service/task.service';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css']
})
export class TaskComponent implements OnInit {

  private url: string = 'https://localhost:44370/api/Tasks';
  private response: any[];
  stepId: number;
  taskId: number
  constructor(private _taskService: TaskService) { }

  ngOnInit() {
    this.GetTasks();
  }

  async GetTasks() {
    this._taskService.getBaseTask(this.url).subscribe(
      (resp: any) => {

        this.response = resp;
        console.log(resp)
      }
    )
  }

  ShowStep(id: number) {

    this.taskId = id;
  }

}
