import { Component, OnInit ,ElementRef} from '@angular/core';
import {FormControl, Validators} from '@angular/forms';
import { NgForm } from '@angular/forms';


@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  login() 
  {
    
  }
  onSubmit()
  {
    console.log("submit the form");
    
    console.warn("try to submit");
  }

}
