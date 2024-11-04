import { Component, inject, OnInit } from '@angular/core';
import { CoolProductsService } from '../../services/coolproducts.service';
import { Product } from '../../models/product';

@Component({
  selector: 'app-products-list',
  standalone: true,
  imports: [],
  templateUrl: './products-list.component.html',
  styleUrl: './products-list.component.css'
})
export class ProductsListComponent implements OnInit {
  
  productsList:Product[]=[];
  errMsg:string=''
  ngOnInit(): void {
    this.productsService.getProducts().subscribe({
      next: (result) => {
        this.productsList = result;
      },
      error: (error) => {
        console.error('Error fetching products:', error);
        this.errMsg = "An error occured while fetching products, try again"
      }
    });
    //sdfsdfsdfsd
    
  }

  productsService: CoolProductsService = inject(CoolProductsService);


}
