namespace UnitConversionApi.Converters; 
public class TemperatureConverter:IUnitConverter { 
    public string Category=>"temperature"; 
    public double Convert(string f,string t,double v){
        if(f=="celsius"&&t=="fahrenheit") 
            return v*9/5+32;
        if(f=="fahrenheit"&&t=="celsius") 
            return (v-32)*5/9; 
        throw new ArgumentException();
        }
}