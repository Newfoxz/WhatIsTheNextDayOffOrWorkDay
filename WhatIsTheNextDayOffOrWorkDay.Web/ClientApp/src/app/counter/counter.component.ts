import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent implements OnInit{

  constructor() {

  }
    ngOnInit(): void {
        throw new Error('Method not implemented.');
    }

  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
