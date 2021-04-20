
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Iproduct } from './Iproduct';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor() { 
    
  }
  product: Iproduct[]=[];
  productForm= new FormGroup({
    Id: new FormControl(null,[Validators.required]),
    Name: new FormControl(null,[Validators.required]),
    ShortCode: new FormControl(null,[Validators.required,Validators.maxLength(4)] ),
    Manufacturer: new FormControl(null,[Validators.required]),
    SellingPrice: new FormControl(null,[Validators.required, Validators.min(0)]),
    Description: new FormControl(null,[Validators.required]),
    Categories: new FormControl(null,[Validators.required]),
    deleteid: new FormControl(null)

  })
  
  onsave()
  {
   var x: Iproduct={
    Id: this.productForm.controls['Id'].value,
    Name:this.productForm.controls['Name'].value,
    Price:this.productForm.controls['SellingPrice'].value,
    Categories: this.productForm.controls['Categories'].value,
    ShortCode: this.productForm.controls['ShortCode'].value,
    Description:this.productForm.controls['Description'].value,
    Manufacturer:this.productForm.controls['Manufacturer'].value,
  
   };
   this.product.push(x);
  
    
    

  }
  onreset()
  {
    this.productForm.reset();

  }
  ondelete()
  {
    var x: number= this.productForm.controls['deleteid'].value;
     this.product.forEach((item,i)=> {
       if(item.Id==x)
       {
        this.product.splice(i,1);
       }
       
     });

  }
  
  

  
  searchById : number;
  searchByShortCode: string;

  ngOnInit(): void {
  }

}
