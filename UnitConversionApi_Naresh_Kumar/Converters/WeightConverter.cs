namespace UnitConversionApi.Converters; 
public class WeightConverter:IUnitConverter { 
    public string Category=>"weight"; 
    public double Convert(string f,string t,double v){
        if(f=="kg"&&t=="lb") 
           return v*2.20462;
        if(f=="lb"&&t=="kg") 
           return v/2.20462; 
        throw new ArgumentException();
        }
}