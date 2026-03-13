import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-body-component',
  standalone: true,
  imports: [],
  templateUrl: './body-component.component.html',
  styleUrl: './body-component.component.css'
})
export class BodyComponentComponent {
  @Input() data:string = '';
  @Output() onButtonClicked = new EventEmitter<{}>();

  buttonClicked():void{
    this.onButtonClicked.emit(`I am clicking button at ${new Date()}`);
  }
}
