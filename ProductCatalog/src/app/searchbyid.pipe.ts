import { Pipe, PipeTransform } from '@angular/core';
import { Iproduct } from './product/Iproduct';

@Pipe({
  name: 'searchbyid'
})
export class SearchbyidPipe implements PipeTransform {

  transform(value: Iproduct[], args: number):Iproduct[] {
    if(!args)
    {
      return value;
    }
    return value.filter(item=>(item.Id== args));
  }

}
