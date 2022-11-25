import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ICity } from 'src/app/models/ICity';
import { IRegistration } from 'src/app/models/IRegistration';
import { IState } from 'src/app/models/IState';
import { BaseService } from 'src/app/services/base.service';


@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  formRegister!: FormGroup
  formData!:IRegistration
  cityList:ICity[]=[];
  stateList:IState[]=[];
  registrationList:IRegistration[]=[];
  constructor(private Master:BaseService) { }

  ngOnInit(): void {
   
  
    this.onit();
    this.OnSave();
    this.  getAllCities();
    this.getStates();
   this.getRandomInt;
    
  

  }


  onit() {
    this.formRegister = new FormGroup({
      firstname: new FormControl(""),
      lastname: new FormControl(""),
      fathername: new FormControl(""),
      mothername: new FormControl(""),
      dob: new FormControl(""),
      gender: new FormControl(""),
      city: new FormControl(""),
      state: new FormControl(""),
    });
  }
  getRandomInt(min:number, max:number) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random()*(max-min)+min);
  }



  OnSave() {
    this.formData={
      //id:this.getRandomInt(10,1000),
      firstName:this.formRegister.controls['firstname'].value,
      lastName:this.formRegister.controls['lastname'].value,
      fatherName:this.formRegister.controls['fathername'].value,
      motherName:this.formRegister.controls['mothername'].value,
      gender:this.formRegister.controls['gender'].value,
      dob:this.formRegister.controls['dob'].value,
      city:this.formRegister.controls['city'].value,
      state:this.formRegister.controls['state'].value,
      // createdDate:this.formRegister.controls['createdate'].value,



    }
    this.Master.CrteateNewMember(this.formData).subscribe(res=>{
      alert(res);
    })
    
  }
  getAllCities()
  {
    this.Master.GetCities().subscribe(res=>
      this.cityList=res
    );
  }
  getStates()
  {
    this.Master.Getstate().subscribe(res=>
      this.stateList=res
    );
  }
}
