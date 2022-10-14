import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{StudentComponent} from './student/student.component';
import { TloginComponent } from './teacher/tlogin/tlogin.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HeaderComponent } from './header/header.component';
import { LoginComponent } from './user/login/login.component';
import { AddrecordComponent } from './teacher/addrecord/addrecord.component';
import { UpdateComponent } from './teacher/update/update.component';
import { DetailsComponent } from './user/details/details.component';
const routes: Routes = [
  {
  path:'Student',
  component:StudentComponent
  },
  {
    path:'Teacher/login',
    component:TloginComponent
  },
  
  {
    path:'Student/login',
    component:LoginComponent
  },
  {
    path:'Student/login/:id',
    component:DetailsComponent
  }
  ,
  {
    path:'Teacher/login/addRecord',
    component:AddrecordComponent
  },
  {
    path:'Teacher/login/update/:id',
    component:UpdateComponent
  },
  {
    path:'',
    component:HeaderComponent
  },
  
  {
    path:'**',
    component:PageNotFoundComponent
  },
  
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
