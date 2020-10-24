import { Injectable } from "@angular/core";
import { Student } from "../models/Student";
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs";



@Injectable()

export class StudentService {

    // students: Student[] = [
    //     {
    //         id: 1,
    //         name: "John",
    //         academicYear: "FirstYear",
    //         dateOfBirth: "2020-10-12",
    //         description: "First Year Student"
    //     },
    //     {
    //         id: 2,
    //         name: "Mostafa",
    //         academicYear: "SecondYear",
    //         dateOfBirth: "2020-10-12",
    //         description: "Second Year Student"
    //     },
    //     {
    //         id: 3,
    //         name: "Sam",
    //         academicYear: "ThirdYear",
    //         dateOfBirth: "2020-10-12",
    //         description: "Third Year Student"
    //     },
    // ];


    baseUrl: string = "https://localhost:44366/api/students"

    constructor(private http: HttpClient) {

    }

    getStudents(): Observable<Student[]> {

        return this.http.get<Student[]>(this.baseUrl);

    }

    getStudent(id: string): Observable<Student> {

        return this.http.get<Student>(this.baseUrl + '/' + Number(id));
    }


    postStudent(newStudent: Student): Observable<Student> {

        return this.http.post<Student>(this.baseUrl, newStudent);

    }

    editStudent(editedStudent: Student): Observable<Student> {

        return this.http.put<Student>(this.baseUrl, editedStudent);

    }

    deleteStudent(id: string): Observable<void> {
        return this.http.delete<void>(this.baseUrl + '/' + Number(id));
    }



}
