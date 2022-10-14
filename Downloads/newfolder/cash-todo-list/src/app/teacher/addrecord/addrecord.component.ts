import { Component, OnInit } from '@angular/core';
import { userObj } from 'src/app/Interface/inter';
import { CommonService } from 'src/app/common.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-addrecord',
  templateUrl: './addrecord.component.html',
  styleUrls: ['./addrecord.component.css']
})
export class AddrecordComponent implements OnInit {


  userObj:userObj;
  constructor(private router:Router) { 
    this.userObj=new userObj();
  }
  
  ngOnInit(): void {
    
  }

  

  getNewUserId()
  {
    const oldrecord=localStorage.getItem('userList');
    if(oldrecord!==null)
    {
      const userList=JSON.parse(oldrecord);
      return userList.length+1;
    }
    else
     return 1;
  }
  saveuser()
  {
      debugger;
      
      const latestId=this.getNewUserId();
      this.userObj.UserId=this.getNewUserId(); 
      const oldrecord=localStorage.getItem('userList');
      if(oldrecord!==null)
      {
        const userList=JSON.parse(oldrecord);
        const check=userList.find((m:any)=>m.Rollnumber==this.userObj.Rollnumber);
        
        
        if(check===undefined)
        {

            userList.push(this.userObj);
            localStorage.setItem('userList',JSON.stringify(userList));
        }
        else{
          alert("Roll Number Exist");
        }
      }
      else
      {
        const userArr=[];
        userArr.push(this.userObj);
        localStorage.setItem('userList',JSON.stringify(userArr));
      }

      this.router.navigateByUrl('/Teacher/login');
  }


  
}
