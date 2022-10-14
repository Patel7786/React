import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
  rollnumber=0;
  name="";
  Score="";
  DOB="";

  
  constructor(private route:ActivatedRoute) 
  { 
    this.route.params.subscribe((res)=>
    {

      this.rollnumber=res['id']
    });
  }

  ngOnInit(): void 
  {
    debugger;
    const oldrecord=localStorage.getItem('userList');
    if(oldrecord!==null)
      {
        const userList=JSON.parse(oldrecord);
        
        for(var i = 0; i < userList.length; i++) 
        {
          if(userList[i].Rollnumber == this.rollnumber) 
          {
              
              this.name=(userList[i].Name);
              this.Score=(userList[i].Score);
              this.DOB=(userList[i].DOB);
              
              break;
          }
      }
      }    
  }

}
