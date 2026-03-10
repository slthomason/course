import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { EmployeeService, Employee } from '../services/employee-service.service';

@Component({
    selector: 'app-employee-detail',
    standalone: true,
    imports: [CommonModule, RouterModule],
    templateUrl: './employee-detail.component.html',
    styleUrls: ['./employee-detail.component.css'] // Corrected 'styleUrl' to 'styleUrls'
})
export class EmployeeDetailComponent implements OnInit {
    employee?: Employee; // Property to hold the employee details

    // Constructor with dependencies injected
    constructor(
        private route: ActivatedRoute, // Inject ActivatedRoute to access route parameters
        private employeeService: EmployeeService // Inject EmployeeService to fetch employee data
    ) { }

    // Lifecycle hook that is called after component initialization
    ngOnInit(): void {
        const id = this.route.snapshot.paramMap.get('id'); // Get the employee ID from the route parameters
        if (id) {
            // Fetch the employee details by ID using the service
            this.employeeService.getEmployeeById(Number(id)).subscribe((data: Employee | undefined) => {
                this.employee = data; // Assign fetched data to the employee property
            });
        }
    }
}