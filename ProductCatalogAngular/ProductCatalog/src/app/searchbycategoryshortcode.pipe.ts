import { Pipe, PipeTransform } from '@angular/core';
import { Icategory } from './category/Icategory';

@Pipe({
  name: 'searchbycategoryshortcode'
})
export class SearchbycategoryshortcodePipe implements PipeTransform {

  transform(value: Icategory[],args: string): Icategory[] {
    if(!args)
    {
      return value;
    }
    return value.filter(item=>item.ShortCode.toLowerCase().indexOf(args.toLowerCase())>-1);
  }

}
