
namespace UnitConversionApi.Converters;
public interface IUnitConverter
{
 string Category {get;}
 double Convert(string from,string to,double value);
}
