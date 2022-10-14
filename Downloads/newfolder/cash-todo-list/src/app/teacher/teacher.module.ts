import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TloginComponent } from './tlogin/tlogin.component';
import { HeadrComponent } from './headr/headr.component';
import { AppRoutingModule } from '../app-routing.module';
import { AddrecordComponent } from './addrecord/addrecord.component';
import { FormsModule } from '@angular/forms';
import { UpdateComponent } from './update/update.component';

@NgModule({
  declarations: [
    TloginComponent,
    HeadrComponent,
    AddrecordComponent,
    UpdateComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    FormsModule
  ],
  exports:[
    TloginComponent,
    HeadrComponent,
    AddrecordComponent
  ]
})
export class TeacherModule { }
