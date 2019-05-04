import { Component, OnInit } from '@angular/core';

import { ValueService } from '../value.service';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {

  public value: number;

  constructor(
    private valueService: ValueService
  ) { }

  ngOnInit() {
    this.valueService.getValue().subscribe(value => this.value = value.value);
  }

}
