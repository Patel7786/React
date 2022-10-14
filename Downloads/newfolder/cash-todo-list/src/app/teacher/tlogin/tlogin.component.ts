import { Component, OnInit } from '@angular/core';
import { CommonService } from 'src/app/common.service';
import { userObj } from 'src/app/Interface/inter';
@Component({
  selector: 'app-tlogin',
  templateUrl: './tlogin.component.html',
  styleUrls: ['./tlogin.component.css']
})
export class TloginComponent implements OnInit {

  userList:userObj[];
  
  constructor(private LocalService: CommonService) {
    this.userList=[];
   }

  ngOnInit(): void {
    const records=localStorage.getItem('userList');
    if(records!==null)
    {
      this.userList=JSON.parse(records);
    }
  }

  delete(id:any)
  {
    debugger;
      
      const oldrecord=localStorage.getItem('userList');
      if(oldrecord!==null)
      {
        const userList=JSON.parse(oldrecord);
        userList.splice(userList.findIndex((a:any)=>a.UserId==id),1);
        
        localStorage.setItem('userList',JSON.stringify(userList));
      }

      const records=localStorage.getItem('userList');
      if(records!==null)
      {
        this.userList=JSON.parse(records);
      }
  }

 


}
