import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form-example',
  templateUrl: './reactive-form-example.component.html',
  styleUrls: ['./reactive-form-example.component.css']
})
export class ReactiveFormExampleComponent {
  langs: string[] = [
    'English',
    'French',
    'German',
  ];
  constructor(private fb: FormBuilder) {
this.myForm = this.fb.group({
    firstName: ["Spancer", Validators.required],
    lastName: ["", Validators.required],
    email: ["", Validators.email],
    password: ["", Validators.required],
    language: ["", Validators.required]
})
  }

  myForm!: FormGroup;

  //= new FormGroup({
  //   firstName: new FormControl('Spancer'),
  //   lastName: new FormControl(''),
  //   email: new FormControl('sp@gmail.com'),
  //   password: new FormControl(''),
  //   language: new FormControl('')
  // });
  onSubmit(form: any) {
    console.log(form);
  }
}
