import { Routes } from '@angular/router';
import { EmployeeListComponent } from './employee-list/employee-list.component';
import { EmployeeDetailComponent } from './employee-detail/employee-detail.component';
import { EmployeeFormComponent } from './employee-form/employee-form.component';

// Define the application routes
export const routes: Routes = [
    { path: 'employees', component: EmployeeListComponent }, // Route for displaying the list of employees
    { path: 'employee/:id', component: EmployeeDetailComponent }, // Route for displaying details of a specific employee by ID
    { path: 'add-employee', component: EmployeeFormComponent }, // Route for adding a new employee
    { path: '', redirectTo: '/employees', pathMatch: 'full' }, // Default route redirects to the employee list
    { path: '**', redirectTo: '/employees' } // Wildcard route for handling 404 errors by redirecting to the employee list
];
