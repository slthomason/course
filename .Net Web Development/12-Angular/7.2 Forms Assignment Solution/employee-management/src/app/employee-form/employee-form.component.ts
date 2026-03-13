import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { NgForm, FormsModule } from '@angular/forms';

@Component({
  selector: 'app-employee-form',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './employee-form.component.html'
})
export class EmployeeFormComponent {
  
  submittedData: any; // Property to store submitted data

  // Handle form submission and call the parent's method
  onSubmit(employeeForm: NgForm) {
    if (employeeForm.valid) {
      this.submittedData = employeeForm.value; // Store form data
      console.log('Form Submitted!', this.submittedData); // Log form data to console
      employeeForm.reset();  // Reset the form after submission
    }
  }
}