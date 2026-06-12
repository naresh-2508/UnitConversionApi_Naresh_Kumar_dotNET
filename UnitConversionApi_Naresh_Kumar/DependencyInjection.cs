
using UnitConversionApi.Converters;
using UnitConversionApi.Services;

public static class DependencyInjection
{
 public static IServiceCollection AddApplicationServices(this IServiceCollection services)
 {
   services.AddScoped<IConversionService,ConversionService>();
   services.AddScoped<IUnitConverter,LengthConverter>();
   services.AddScoped<IUnitConverter,TemperatureConverter>();
   services.AddScoped<IUnitConverter,WeightConverter>();
   return services;
 }
}
