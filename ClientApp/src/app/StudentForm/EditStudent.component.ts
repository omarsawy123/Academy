import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Student } from '../models/Student';
import { StudentService } from '../services/student.services';

@Component({
    selector: "app-edit-student",
    templateUrl: "./add-student.component.html",
    styleUrls: ["./add-student.component.css"]
})

export class EditStudentComponent implements OnInit {

    studentForm: FormGroup;

    student: Student;

    students: Student[];

    HeaderText: string = "Edit Student"

    constructor(private fb: FormBuilder, private _studentservice: StudentService, private _router: Router,
        private _activatedroute: ActivatedRoute) { }

    ngOnInit() {

        this.studentForm = this.fb.group({

            name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(20)]],
            AcademicYear: ['', [Validators.required]],
            DateOfBirth: ['', [Validators.required]],
            Description: ['', [Validators.required]]

        })

        let studId = this._activatedroute.snapshot.params['id']
        this._studentservice.getStudent(studId).subscribe(data => this.student = data);

        this.studentForm.setValue({
            name: this.student.name,
            AcademicYear: this.student.academicYear,
            DateOfBirth: this.student.dateOfBirth,
            Description: this.student.description
        })

        return this._studentservice.getStudents().subscribe(data => this.students = data);

    }

    saveStudent(editedStudent: Student) {
        if (editedStudent.id != null) {

            this._studentservice.editStudent(editedStudent).subscribe(data => this.students.push(editedStudent));


        }

        this._router.navigate(["/blog"]).then(() => {
            window.location.reload();
        });
    }

    deleteStudent(studId: string) {

        if (confirm("Are you sure you want to delete this student?")) {


            if (studId != null) {
                this._studentservice.deleteStudent(studId).subscribe();
            }

            this._router.navigate(["/blog"]).then(() => {
                window.location.reload();
            });
        }
    }
}