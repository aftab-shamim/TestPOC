import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { isNumber } from 'util';
import { Employee } from './Models/employee';
import { EmployeeService } from './Shared/employee.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TestPoc';
  employeeDetails : Employee;
  employeeList : Employee[];
  isList : boolean = false;
  isDetails :boolean = false;
  employee:FormGroup;  
  getEmployee:any;
  
  empId: any;
  constructor(private employeeService:EmployeeService) {
    this.employee = new FormGroup({
      empId: new FormControl(null)
    });
   }
  ngOnInit() {    
  }
  GetEmployee(event)
  {
    debugger;
   this.empId=this.employee.value.empId;
    if(this.empId){
      if(isNumber(this.empId)){
        alert("Please Enter only numeric value");
      }
        this.isDetails = true;
        this.isList = false;
        this.getEmployeeById(this.empId);
      }
      else{
      this.isList = true;
      this.isDetails = false;
       this.getAllEmployee();
      }
  }

  getEmployeeById(empId:number){
    this.employeeService.getEmployeeById(empId)
    .subscribe(
      res => {
      this.employeeDetails=res;
      console.log(this.GetEmployee);
        })
  }

  getAllEmployee(){    
    debugger;
    this.employeeService.getAllEmployee().subscribe(
      (data) => {
        this.employeeList=data;
        // console.log(this.employeeList);
      }
    )
  }

  
}

