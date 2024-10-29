import { CurrencyPipe, UpperCasePipe } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { CounterComponent } from './counter/counter.component';
import { ShowProductComponent } from './show-product/show-product.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,UpperCasePipe,CurrencyPipe,FormsModule, CounterComponent,ShowProductComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'data-binding-demo';
  name:string='Venkat';
  isSelected:boolean=true;
  


  btnClicked()
  {
    alert('button clicked');
  }
}
