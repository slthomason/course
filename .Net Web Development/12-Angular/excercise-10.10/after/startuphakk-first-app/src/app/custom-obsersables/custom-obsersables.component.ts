import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-custom-obsersables',
  templateUrl: './custom-obsersables.component.html',
  styleUrls: ['./custom-obsersables.component.css']
})
export class CustomObsersablesComponent implements OnInit {
  customObserableSubs: Subscription | undefined;

  currentTime: string | undefined;

  ngOnInit(): void {
    this.customObserableSubs =   this.customObserableTimer.subscribe((time) => {
      this.currentTime = time;
    });

    // this.customObserableSubs.unsubscribe()
  }

  customObserableTimer = new Observable<string>((observer) => {
    setInterval(() => {
      observer.next(new Date().toLocaleDateString() + " " + new Date().toLocaleTimeString())

    }, 1000);


    setTimeout(() => {
      observer.complete()
    }, 10000);

    //
    
///


observer.next("Stopped")

    //observer.error();

  })

}
