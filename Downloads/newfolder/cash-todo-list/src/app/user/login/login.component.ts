import { NgFor, NgIf } from '@angular/common';
import { ExpressionType } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { Router, UrlTree } from '@angular/router';


@Component({
  selector: 'app-login',
  template:'<input [(ngModel)]="data.Name" type="text">',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

Name="";
rollnumber=0;

  constructor(private router:Router) { }
 
  ngOnInit(): void {
  }


  search()
  {
    debugger;
    const oldrecord=localStorage.getItem('userList');
    
    if(oldrecord!==null)
      {
        const userList=JSON.parse(oldrecord);
        
        for(var i = 0; i < userList.length; i++) 
        {
          
          if(userList[i].Rollnumber === this.rollnumber && userList[i].Name==this.Name) 
          {
              this.router.navigateByUrl('/Student/login/'+userList[i].Rollnumber);
              break;
          }

        }
        if(i>=userList.length)
        {
          alert("Either Rollnumber or Name is In correct");
        }
      }   
       
      
      
  }

}
