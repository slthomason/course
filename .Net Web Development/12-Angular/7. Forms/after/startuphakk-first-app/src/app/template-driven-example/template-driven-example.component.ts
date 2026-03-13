import { Component } from '@angular/core';

@Component({
  selector: 'app-template-driven-example',
  templateUrl: './template-driven-example.component.html',
  styleUrls: ['./template-driven-example.component.css']
})
export class TemplateDrivenExampleComponent {

  langs: string[] = [
    'English',
    'French',
    'German',
  ];


  formObj: any = {};

  onSubmit() {
    console.log(this.formObj);
  }
}
