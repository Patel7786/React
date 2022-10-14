import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { userObj } from 'src/app/Interface/inter';
@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit 
{
  data={
    rollnumber:Number,
    name:String,
    DOB:Date,
    Score:Number,

  }

  userObj:userObj;
  constructor(private route:ActivatedRoute ,private router:Router) 
  { 
    this.userObj=new userObj();
    this.route.params.subscribe((res)=>{
      this.userObj.UserId=res['id']
    });
  }
  
  ngOnInit(): void 
  {
    debugger;
    const oldrecord=localStorage.getItem('userList');
    if(oldrecord!==null)
    {
      const userList=JSON.parse(oldrecord);
      const currentUser=userList.find((m:any)=>m.UserId==this.userObj.UserId);
      if(currentUser!==undefined)
      {
        this.userObj.Name=currentUser.Name;
        this.userObj.Rollnumber=currentUser.Rollnumber;
        this.userObj.DOB=currentUser.DOB;
        this.userObj.Score=currentUser.Score;
      }
    }
  }

  Updateuser()
  {
      debugger;
      
      const oldrecord=localStorage.getItem('userList');
      if(oldrecord!==null)
      {
        const userList=JSON.parse(oldrecord);
        const cpy=userList.findIndex((a:any)=>a.UserId==this.userObj.UserId);
        this.data.name=cpy.Name;
        this.data.rollnumber=cpy.Rollnumber;
        this.data.DOB=cpy.DOB;
        this.data.Score=cpy.Score;
        userList.splice(userList.findIndex((a:any)=>a.UserId==this.userObj.UserId),1);
        userList.push(this.userObj);
        localStorage.setItem('userList',JSON.stringify(userList));
      }
      this.router.navigateByUrl('/Teacher/login')
  }

  
}
