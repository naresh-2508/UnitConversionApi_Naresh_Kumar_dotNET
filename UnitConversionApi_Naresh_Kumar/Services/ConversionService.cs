
using UnitConversionApi.Converters;
using UnitConversionApi.Models;

namespace UnitConversionApi.Services;

public class ConversionService:IConversionService
{
 private readonly IEnumerable<IUnitConverter> _converters;
 public ConversionService(IEnumerable<IUnitConverter> converters)=>_converters=converters;

 public ConversionResponse Convert(ConversionRequest request)
 {
   var converter=_converters.FirstOrDefault(x=>x.Category.Equals(request.Category,StringComparison.OrdinalIgnoreCase));
   if(converter is null) throw new InvalidOperationException("Category not supported");

   var result=converter.Convert(request.FromUnit.ToLower(),request.ToUnit.ToLower(),request.Value);
   return new ConversionResponse(request.Value,request.FromUnit,request.ToUnit,result);
 }
}
