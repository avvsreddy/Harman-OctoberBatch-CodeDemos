import { CurrencyPipe, NgFor, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { Product } from '../../model/product';

@Component({
  selector: 'app-show-product',
  standalone: true,
  imports: [NgFor,CurrencyPipe,NgIf],
  templateUrl: './show-product.component.html',
  styleUrl: './show-product.component.css'
})
export class ShowProductComponent {
products:Product[]=[
  {
  id:123,
  name:'I Phone 16',
  price:98000,
  inStock:false,
  //abc:23434
  
},
{ id:222,
  name:'I Phone 16 Pro',
  price:99000,
  inStock:true},
{ id:333,
  name:'I Phone 16 Max',
  price:99999,
  inStock:false}
]
}
