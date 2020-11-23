import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BaseApiService } from './base-api.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

 
  constructor(private baseApiService: BaseApiService) { }

  getAllEmployee(): Observable<any> {
    return this.baseApiService.getAllEmployee();
  }
  getEmployeeById(id:number): Observable<any> {
    return this.baseApiService.getEmployeeById(id);
  }


}
