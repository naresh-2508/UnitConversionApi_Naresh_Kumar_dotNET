namespace UnitConversionApi.Converters; 
public class LengthConverter:IUnitConverter {
       public string Category=>"length"; 
       public double Convert(string f,string t,double v)
         {
            if(f=="meter"&&t=="feet") 
             return v*3.28084;
            if(f=="feet"&&t=="meter") 
             return v/3.28084; 
            throw new ArgumentException();
          }
    }