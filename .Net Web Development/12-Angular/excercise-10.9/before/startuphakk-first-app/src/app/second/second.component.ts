import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.css']
})
export class SecondComponent {
  constructor(private router: Router) {

  }


  hobbies = [{
    id: 1,
    hobby: "Football"
  }, {
    id: 2,
    hobby: "Ice Hockey"
  }
    , {
    id: 3,
    hobby: "Baseball"
  }, {
    id: 4,
    hobby: "Badminton"
  }]

  viewHobbyDetail(hobby: any) {

    this.router.navigate(['/hobby-detail', hobby.id]);

  }

}
