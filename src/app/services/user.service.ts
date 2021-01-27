import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpClient) { }

  getDepartments() : Observable<any>{
    return this.http.get("https://localhost:44377/api/department",{
      headers: {
        'method': 'GET' 
        ,'Accept': 'application/json'
        ,'withCredentials': 'true'
       ,'Access-Control-Allow-Origin':'*'
      }});
  }
}
