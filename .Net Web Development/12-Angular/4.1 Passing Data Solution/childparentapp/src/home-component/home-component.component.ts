import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { BodyComponentComponent } from '../body-component/body-component.component';

@Component({
  selector: 'app-home-component',
  standalone: true,
  imports: [BodyComponentComponent],
  templateUrl: './home-component.component.html',
  styleUrl: './home-component.component.css'
})
export class HomeComponentComponent implements OnChanges{
  @Input() data:string = '';
  dataSendToBodyComponent:string='';

  ngOnChanges(changes: SimpleChanges): void {
    this.dataSendToBodyComponent = 'NgOnChanges Called';
  }

  alertThePopup(message:any){
    alert(message);
  }

}
