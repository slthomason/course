import { Component } from '@angular/core';

@Component({
  selector: 'app-directive-example',
  templateUrl: './directive-example.component.html',
  styleUrls: ['./directive-example.component.css']
})
export class DirectiveExampleComponent {

  colorfulDiv:string="pink-color-text";

  divStyle:any={
    "font-size":"50px"
  }

  userName:string="Spener Thomson";

  CanViewDivBlock:boolean=true;

  age:number=20;


  hobbies:string[] =["reading book", "sleeping","playing football"];

  ageGroup: string = "teenage"; // "toddler/infant/teenage/adult"
}
