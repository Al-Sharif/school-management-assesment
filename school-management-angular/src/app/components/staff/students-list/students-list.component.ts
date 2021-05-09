import { Component, OnInit } from '@angular/core';
import { UserViewModel } from 'src/app/models/register';
import { StaffService } from 'src/app/services/staff.service';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit {
  students: UserViewModel[] = [];
  constructor(private _staffService: StaffService) { }

  ngOnInit(): void {
    this._staffService.getStudents().subscribe(res =>{
      this.students = res;
    });
  }

}
