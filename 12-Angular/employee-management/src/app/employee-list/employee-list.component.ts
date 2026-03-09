import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { Employee, EmployeeService } from '../services/employee-service.service';

@Component({
    selector: 'app-employee-list',
    standalone: true,
    imports: [CommonModule, RouterModule],
    templateUrl: './employee-list.component.html',
    styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent {
    employees: Employee[] = []; // Initialize an empty array to hold employee data

    // Inject EmployeeService to get employee data
    constructor(private employeeService: EmployeeService) { }

    // Lifecycle hook that runs after the component is initialized
    ngOnInit(): void {
        // Call the getEmployees() method from the service, which returns an observable
        // Subscribe to the observable to get the employee data
        this.employeeService.getEmployees().subscribe((data: Employee[]) => {
            this.employees = data; // Assign the fetched data to the local `employees` array
        });
    }
}
