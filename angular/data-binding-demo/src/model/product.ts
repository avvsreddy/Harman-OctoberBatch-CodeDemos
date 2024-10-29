export interface Product
{
    id:number;
    name:string;
    price:number;
    inStock:boolean;
}


export class Item
{
    // id:number;
    // name:string;
    // price:number;
    // inStock:boolean;

    constructor(public id:number,
        public name:string, public price:number,  public inStock:boolean)
    {
    this.id=0;
    this.name='';
    this.price=0;
    this.inStock=true;
    }

}

let item:Item = new Item(111,'asfsdf',34545,true);
let product:Product={id:234,name:'wewerwer',price:343,inStock:true};