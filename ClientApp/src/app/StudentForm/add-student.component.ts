import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Student } from '../models/Student';
import { StudentService } from '../services/student.services';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {

  studentForm: FormGroup;

  students: Student[];

  HeaderText: string = "Add New Student"


  student: Student = {
    id: null,
    name: '',
    academicYear: '',
    dateOfBirth: '',
    description: '',
  }


  constructor(private fb: FormBuilder, private _studentservice: StudentService, private _router: Router) { }

  ngOnInit() {

    this._studentservice.getStudents().subscribe(data => this.students = data);


    this.studentForm = this.fb.group({

      name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(20)]],
      AcademicYear: ['', [Validators.required]],
      DateOfBirth: ['', [Validators.required]],
      Description: ['', [Validators.required]]

    })

    this.studentForm.setValue({
      name: this.student.name,
      AcademicYear: this.student.academicYear,
      DateOfBirth: this.student.dateOfBirth,
      Description: this.student.description
    })

  }

  saveStudent(newStudent: Student) {

    if (newStudent.id == null) {

      newStudent.id = (Number(this.students[this.students.length - 1].id)+ 1).toString();

      this._studentservice.postStudent(newStudent).subscribe(data => this.students.push(newStudent));

    }
    this._router.navigate(["/blog"]).then(() => {
      window.location.reload();
    });
  }

}
