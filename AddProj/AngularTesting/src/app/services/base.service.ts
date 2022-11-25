import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICity } from '../models/ICity';
import { IRegistration } from '../models/IRegistration';
import { IState } from '../models/IState';

@Injectable({
  providedIn: 'root'
})
 


export class BaseService {

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':  'application/json',
      'Accept': 'application/json'
    })
  };



  url1="http://localhost:5251/api/Cities/GetCities";
  url2="http://localhost:5251/api/State/GetState";
  url3="http://localhost:5251/api/Registration/AddPerson";
  url4="";
  constructor(private http:HttpClient) { }


  GetCities():Observable<ICity[]>
  {
    return this.http.get<ICity[]>(this.url1);

  }
  Getstate():Observable<IState[]>
  {
    return this.http.get<IState[]>(this.url2);
  }
 
 CrteateNewMember(req:IRegistration):Observable<any>
 {
  return this.http.post(this.url3,req, this.httpOptions)
 }
 getAllMembers():Observable<any>
 {
  return this.http.get<any>(this.url4);
 }



}
