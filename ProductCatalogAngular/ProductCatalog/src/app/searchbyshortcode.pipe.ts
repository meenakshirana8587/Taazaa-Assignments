import { Pipe, PipeTransform } from '@angular/core';
import { Iproduct } from './product/Iproduct';

@Pipe({
  name: 'searchbyshortcode'
})
export class SearchbyshortcodePipe implements PipeTransform {

  transform(value: Iproduct[],args: string): Iproduct[] {
    if(!args)
    {
      return value;
    }
    return value.filter(item=>item.ShortCode.toLowerCase().indexOf(args.toLowerCase())>-1);
  }

}
