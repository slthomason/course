import { Injectable } from '@angular/core'; 
import { Observable, of } from 'rxjs';

// Define the Employee interface, which describes the shape of an employee object.
// It includes four properties: id, name, age, and email.
export interface Employee {
    id: number;   // Unique identifier for each employee
    name: string; // Employee's full name
    age: number;  // Employee's age
    email: string; // Employee's email address
}

@Injectable({
    providedIn: 'root', 
    // The `providedIn: 'root'` specifies that this service is a singleton and is available application-wide.
    // This means that Angular will create a single instance of this service and provide it throughout the app.
})
export class EmployeeService {
    // Create a private array of employees to simulate a list of employee records.
    // This is where we store our employee data in-memory. In a real-world application, this would be fetched from a database or API.
    private employees: Employee[] = [
        { id: 1, name: 'John Doe', age: 30, email: 'john.doe@example.com' },
        { id: 2, name: 'Jane Smith', age: 25, email: 'jane.smith@example.com' },
    ];

    constructor() { }

    // This method retrieves all employees as an Observable.
    // An Observable is a stream of data that can be subscribed to and listened for changes or updates.
    // Here, we're using `of` from RxJS to return a mock Observable containing the list of employees.
    getEmployees(): Observable<Employee[]> {
        return of(this.employees); // Returns an Observable that emits the list of employees
    }

    // This method retrieves an employee by their ID.
    // It uses the `find` method to search for an employee in the array that matches the provided `id`.
    // If the employee is found, it returns an Observable of the employee; otherwise, it returns `undefined`.
    getEmployeeById(id: number): Observable<Employee | undefined> {
        const employee = this.employees.find(emp => emp.id === id); // Find employee by ID
        return of(employee); // Return an Observable containing the employee or undefined if not found
    }

    // This method adds a new employee to the list.
    // It automatically assigns a new, unique ID to the employee before adding them to the `employees` array.
    // The updated list of employees is then returned as an Observable.
    addEmployee(employee: Employee): Observable<Employee[]> {
        // Assign a new ID to the employee. If there are existing employees, find the highest ID and increment it by 1.
        // Otherwise, start with ID 1 for the first employee.
        const newId = this.employees.length > 0 ? Math.max(...this.employees.map(emp => emp.id)) + 1 : 1;
        employee.id = newId; // Set the new ID
        this.employees.push(employee); // Add the new employee to the array
        return of(this.employees); // Return an Observable containing the updated list of employees
    }
}