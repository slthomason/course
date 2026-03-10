import {
    Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges, ViewChild
} from "@angular/core";


@Component({
    selector: 'child',
    template: `
    <h1>child!</h1>
    <p>{{userName}},{{masterName}},{{parentCounter}}</p>
  `
})
export class ChildComponent implements OnChanges, OnInit {
   
    @Input()
    userName: string = "";

    @Input('master')
    masterName = '';

    // intercept changes with input setter
    @Input()
    get parentCounter(): number { return this._parentCounter; }

    set parentCounter(counterValue: number) {
        this._parentCounter = counterValue;
    }
    _parentCounter = 0;

    ngOnChanges(changes: SimpleChanges): void {
        console.log(changes);
    }

    // child event
    @Output()
    childCounterEmitter = new EventEmitter<number>();

    childCounter: number = 0;

    ngOnInit(): void {

        setInterval(() => {
            this.childCounter++;
            this.childCounterEmitter.emit(this.childCounter);
        }, 2000);

      
    }

    childMethod(){
        console.log("child method called successfully")
    }

}


@Component({
    selector: 'parent',
    template: `
    <h1>Parent!</h1>
    <button (click)="child.childMethod()">local variable approach</button>
    <button (click)="parentbuttonClick()">ViewChild  approach</button>
    <child [userName]="name" [master]="master" [parentCounter]="counter"
    (childCounterEmitter)="childInformationUpdated($event)" #child ></child>
  `
})
export class ParentComponent implements OnInit {
    ngOnInit(): void {
        setInterval(() => {
            this.counter++;
        }, 2000);
    }
    name: string = "Spencer";
    master: string = "Thomson";
    counter: number = 2;

    childInformationUpdated(evnt: number) {
        console.log(evnt)
    }

    @ViewChild(ChildComponent)
    private childComp!: ChildComponent;

    parentbuttonClick(){
        this.childComp.childMethod();
    }
  
}