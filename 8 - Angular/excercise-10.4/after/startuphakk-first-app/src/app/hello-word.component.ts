import { Component } from '@angular/core';

@Component({
    selector: 'hello-world',
    template: `
    <h1>World!</h1>
      <p>This template definition spans multiple lines.</p>
      <p>user Name is : {{userName|uppercase}}</p>
      <input [(ngModel)]="userName" />
      <br>
      <img [src]="url" />
      <button (click)="onSave()">Save</button>
      
  `
})
export class HelloWorldComponent {
  userName : string = "Spencer Thomson"
  url:string ="https://www.startuphakk.com/wp-content/uploads/2022/07/cropped-StartupHakk.jpg";

  onSave(){
    console.log("saved successfully");
  }

}
