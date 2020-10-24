import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLinkActive } from '@angular/router';
import { Student } from '../models/Student';
import { StudentService } from '../services/student.services';

@Component({
  selector: 'app-view-student',
  templateUrl: './view-student.component.html',
  styleUrls: ['./view-student.component.css']
})
export class ViewStudentComponent implements OnInit {

  student: Student;

  constructor(private _studentservices: StudentService, private _approuter: ActivatedRoute) { }

  ngOnInit() {

    let studId = this._approuter.snapshot.params['id']
    return this._studentservices.getStudent(studId).subscribe(data => this.student = data);
    console.log(this.student)
  }

}
