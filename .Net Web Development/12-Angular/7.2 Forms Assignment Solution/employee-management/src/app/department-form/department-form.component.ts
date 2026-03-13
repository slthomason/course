import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-department-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './department-form.component.html',
})
export class DepartmentFormComponent {
  departmentForm: FormGroup; // Reactive form group
  submittedData: any; // Property to store submitted data

  constructor(private fb: FormBuilder) {
    // Initialize the form group
    this.departmentForm = this.fb.group({
      name: ['', Validators.required],
      head: ['', Validators.required],
      budget: ['', [Validators.required, Validators.min(0)]]
    });
  }

  // Handle form submission
  onSubmit() {
    if (this.departmentForm.valid) {
      this.submittedData = this.departmentForm.value; // Store form data
      console.log('Department Form Submitted!', this.submittedData); // Log form data to console
      this.departmentForm.reset();  // Reset the form after submission
    }
  }
}
