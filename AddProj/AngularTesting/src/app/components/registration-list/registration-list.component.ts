import { Component, OnInit } from '@angular/core';
import { BaseService } from 'src/app/services/base.service';

@Component({
  selector: 'app-registration-list',
  templateUrl: './registration-list.component.html',
  styleUrls: ['./registration-list.component.css']
})
export class RegistrationListComponent implements OnInit {

  constructor(private master:BaseService) { }
  MamberList:any[]=[];

  ngOnInit(): void {
    this.getAllMemberList();
    
  }
  getAllMemberList()
  {
    this.master.getAllMembers().subscribe(res=>{
      this.MamberList=res;
    })
  }

}
