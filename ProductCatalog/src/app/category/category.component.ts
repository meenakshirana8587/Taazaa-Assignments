import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Icategory } from './Icategory';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  constructor() { 
 
  }

  category: Icategory[]=[];
  categoryForm= new FormGroup({
    Id: new FormControl(null,[Validators.required]),
    Name: new FormControl(null,[Validators.required]),
    ShortCode: new FormControl(null,[Validators.required,Validators.maxLength(4)] ),
    
    Description: new FormControl(null,[Validators.required]),
    deleteid: new FormControl(null)

    

  })
  
  onsave()
  {
    var x: Icategory={
      Id: this.categoryForm.controls['Id'].value,
      Name:this.categoryForm.controls['Name'].value,
      
      ShortCode: this.categoryForm.controls['ShortCode'].value,
      Description:this.categoryForm.controls['Description'].value
       
    };
    this.category.push(x);
   
    
    

  }
  onreset()
  {
    this.categoryForm.reset();

  }
  ondelete()
  {
    var x: number= this.categoryForm.controls['deleteid'].value;
     this.category.forEach((item,i)=> {
       if(item.Id==x)
       {
        this.category.splice(i,1);
       }
       
     });

  }
  

  
  ngOnInit(): void {
  }
  searchById: number;
  searchByShortCode: string;
}


