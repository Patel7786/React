import { Injectable } from '@angular/core';
import { AddrecordComponent } from './teacher/addrecord/addrecord.component';

@Injectable({
  providedIn: 'root'
})
export class CommonService {

  
  constructor() { }

  adduser(data:any)
  {
    
    localStorage.setItem(data.RollNumber, JSON.stringify(data)); 
  }

  getData() {
    return localStorage.getItem("1");
 }
}
