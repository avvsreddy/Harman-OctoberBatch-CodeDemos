import { Component } from '@angular/core';
import { fakeAsync } from '@angular/core/testing';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [],
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.css'
})
export class CounterComponent {
count:number=1;
isIncrease:boolean=true;
isDecrease:boolean=true;
onIncrease(){
  this.count++;
  if(this.count >= 10)
    this.isIncrease= false;
  else
    this.isDecrease = true;
}

onDecrease(){
  this.count--;
  if(this.count <= 1)
    this.isDecrease = false;
  else
    this.isIncrease = true;
}
}
