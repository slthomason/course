import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HomeComponentComponent } from '../home-component/home-component.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,HomeComponentComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit{
  title = 'childparentapp';
  dataToPass:string = 'Basic Text';

  ngOnInit(): void {
      this.dataToPass = 'I am coming from the app component';
  }
}
