# EmployeeManagement

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 18.2.6.

# Employee Management System in Angular

## Overview
In this assignment, it will demo of Employee Management System using Angular. The application will allow users to perform CRUD (Create, Read, Update, Delete) operations on employees. It will include concepts of services, dependency injection, routing, navigation, and RxJS with Observables to handle asynchronous operations.

## Project Requirements

### Angular Services & Dependency Injection
- Create an `EmployeeService` to handle CRUD operations (get, create, update, delete) using a private array variable of employees to simulate a list of employee records.
- Inject this service into the relevant components (e.g., `EmployeeListComponent`, `EmployeeDetailComponent`, `EmployeeFormComponent`).

### Routing & Navigation
- Implement routing with at least three routes:
  - `/employees`: Displays a list of employees.
  - `/employees/:id`: Displays details of a selected employee.
  - `/add-employee`: Provides a form to add a new employee.
- Use the Angular Router for navigation between these components.

### Components
- **EmployeeListComponent**: Displays a list of employees. Each employee should have an option to view details or delete.
- **EmployeeDetailComponent**: Displays detailed information about an employee selected from the list.
- **EmployeeFormComponent**: Allows adding and editing employee details.

### RxJS and Observables
- Use RxJS Observables in the `EmployeeService` to simulate asynchronous data fetching.
- Handle subscription and unsubscription properly in components to manage memory leaks.

## Steps to Complete the Assignment

### Set Up the Angular Project
1. Generate a new Angular project using:
   ```bash
   ng new employee-management

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
