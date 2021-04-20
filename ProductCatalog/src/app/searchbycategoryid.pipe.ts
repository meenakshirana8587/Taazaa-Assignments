import { Pipe, PipeTransform } from '@angular/core';
import { Icategory } from './category/Icategory';

@Pipe({
  name: 'searchbycategoryid'
})
export class SearchbycategoryidPipe implements PipeTransform {

  transform(value: Icategory[], args: number):Icategory[] {
    if(!args)
    {
      return value;
    }
    return value.filter(item=>(item.Id== args));
  }

}
