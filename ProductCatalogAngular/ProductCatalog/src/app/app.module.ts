import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SearchbyidPipe } from './searchbyid.pipe';
import { SearchbyshortcodePipe } from './searchbyshortcode.pipe';
import { SearchbycategoryidPipe } from './searchbycategoryid.pipe';
import { SearchbycategoryshortcodePipe } from './searchbycategoryshortcode.pipe';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    CategoryComponent,
    SearchbyidPipe,
    SearchbyshortcodePipe,
    SearchbycategoryidPipe,
    SearchbycategoryshortcodePipe,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
