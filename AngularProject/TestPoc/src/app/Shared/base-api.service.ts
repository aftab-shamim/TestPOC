import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BaseApiService {
  private _Url = 'https://localhost:44338/api';
  //localhost:44338/api/Employee/GetAllEmployee
  
    readonly reqHeader = new HttpHeaders({ 'Content-Type': 'application/json', 'Authorization': 'False' });
    readonly controller = {
  
    Employee:'/employee',
   
  };

  constructor(private httpClient: HttpClient)
  { }

  getAllEmployee() {
    return this.httpClient.get(this._Url + this.controller.Employee + '/GetAllEmployee');
  }
  getEmployeeById(id:number) {
    return this.httpClient.get(this._Url + this.controller.Employee + '/GetEmployeeByID/' + id);
  }

}
