import { Component, OnInit } from '@angular/core';
import { Student } from '../models/Student';
import { StudentService } from '../services/student.services';

@Component({
  selector: 'app-list-student',
  templateUrl: './list-student.component.html',
  styleUrls: ['./list-student.component.css']
})
export class ListStudentComponent implements OnInit {

  students: Student[];

  SearchTerm: string;

  currentSelectedYear: string = "AllYears"


  constructor(private _studentservice: StudentService) { }

  ngOnInit() {


    this._studentservice.getStudents().subscribe(data => this.students = data);

    console.log(this.students.values)

  }

  OnselectChanged(selectedValue: string) {
    this.currentSelectedYear = selectedValue;
    console.log(this.currentSelectedYear);
  }



}
