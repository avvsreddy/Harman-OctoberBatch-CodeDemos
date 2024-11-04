import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Product } from '../../models/product';
import { HttpClient } from '@angular/common/http';
import { CoolProductsService } from '../../services/coolproducts.service';

@Component({
  selector: 'app-product-create',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './product-create.component.html',
  styleUrl: './product-create.component.css'
})
export class ProductCreateComponent {
coolProductService:CoolProductsService = inject(CoolProductsService);
msg:string='';
  onFormSubmit() {
    console.log(this.product);
      this.coolProductService.postProduct(this.product).subscribe({
        next: () => {
          msg:  'Product created successfully';
          console.log('Product created successfully')},
        error: (error) => 

          {
            msg:'Error creating product:';
            console.error('Error creating product:', error)}
      });
}

product:Product={
  id:0,
  name:'',
  brand:'',
  price:0,
  inStock:false,
  country:'',
  category:''
}


}
