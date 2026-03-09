import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { NgForm, FormsModule } from '@angular/forms';
import { EmployeeService, Employee } from '../services/employee-service.service';
import { Router } from '@angular/router';

@Component({
	selector: 'app-employee-form',
	standalone: true,
	imports: [FormsModule, CommonModule],
	templateUrl: './employee-form.component.html',
	styleUrl: './employee-form.component.css'
})
export class EmployeeFormComponent {
	// Property to store the data submitted from the form
    submittedData?: Employee;

    // Inject EmployeeService to handle CRUD operations and Router for navigation after submission
    constructor(
        private employeeService: EmployeeService,
        private router: Router) { }

    // Method to handle form submission
    // The `employeeForm` argument is an instance of `NgForm` (which contains form data and validation state)
    onSubmit(employeeForm: NgForm) {
        if (employeeForm.valid) { // Check if the form is valid (i.e., all required fields are filled)
            this.submittedData = employeeForm.value; // Store the submitted form data into `submittedData`
            if (this.submittedData) {
                // Add the new employee using the service, which returns an Observable
                this.employeeService.addEmployee(this.submittedData).subscribe(() => {
                    console.log('Form Submitted!', this.submittedData); // Log the submitted data
                    employeeForm.reset();  // Reset the form after successful submission
                    // Navigate back to the employee list after submission
                    this.router.navigate(['/employees']);
                });
            }
        }
    }
}
