import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { HdrComponent } from './hdr/hdr.component'; 
import { AppRoutingModule } from '../app-routing.module';
import { FormsModule } from '@angular/forms';
import { DetailsComponent } from './details/details.component';

@NgModule({
  declarations: [
    LoginComponent,
    HdrComponent,
    DetailsComponent
  ],
  imports: [
    CommonModule,
    MatFormFieldModule,
    AppRoutingModule,
    FormsModule
    
  ],
  exports:[
    LoginComponent,
    HdrComponent
  ]
  
})
export class UserModule { }
