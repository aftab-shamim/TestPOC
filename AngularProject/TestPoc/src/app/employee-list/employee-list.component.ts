import { Component, Input, OnInit } from '@angular/core';
import { Employee } from '../Models/employee';
import { EmployeeService } from '../Shared/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  @Input() employeeList : Employee[];

  constructor(private employeeService:EmployeeService) { }

  

  ngOnInit() {
  
    //  this.employeeService.getAllEmployee().subscribe(
    //   (data) => {
    //     this.EmployeeList=data;
    //     console.log(this.EmployeeList);
    //   }
    //)
    console.log(this.employeeList);

  }


}
