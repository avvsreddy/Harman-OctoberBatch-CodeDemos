import { HttpClient } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { Product } from "../models/product";
import { ProductsBaseURI } from "../infrastructure/apiurls";


@Injectable(
{
    providedIn: 'root'
}
)
export class CoolProductsService
{
    public http:HttpClient;
    constructor(http:HttpClient)
    {
        this.http = http;
    }
    //httpClient:HttpClient = inject(HttpClient);

    getProducts(){
          return  this.http.get<Product[]>(ProductsBaseURI +'api/coolproducts', { headers: { 'accept': 'application/json' } });
    }

    postProduct(product:Product){
        return this.http.post<Product>(ProductsBaseURI +'api/coolproducts',product);
    }
}