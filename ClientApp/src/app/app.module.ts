import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { ListStudentComponent } from './students/list-student.component';
import { StudentService } from './services/student.services';
import { ViewStudentComponent } from './students/view-student.component';
import { AddStudentComponent } from './StudentForm/add-student.component';
import { EditStudentComponent } from './StudentForm/EditStudent.component';
import { YearFilterComponent } from './Addons/filter.component';



const approutes: Routes = [
  { path: 'students', component:ListStudentComponent,pathMatch:"full" },
  { path: '', redirectTo:'students',pathMatch:"full" },
  { path: 'students/:id', component:ViewStudentComponent,pathMatch:"full" },
  { path: 'add', component:AddStudentComponent },
  { path: 'edit/:id', component:EditStudentComponent },
  { path: '**', redirectTo:'students',pathMatch:"full" },

]



@NgModule({
  declarations: [
    AppComponent,
    ListStudentComponent,
    ViewStudentComponent,
    AddStudentComponent,
    EditStudentComponent,
    YearFilterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot(approutes)
  ],
  providers: [StudentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
