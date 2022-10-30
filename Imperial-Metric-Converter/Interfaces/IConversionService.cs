namespace Imperial_Metric_Converter.Interfaces
{
    public interface IConversionService
    {
        decimal ConvertCelsiousToFahrenheit(decimal celsious);
        decimal ConvertFahrenheitToCelsious(decimal Fahrenheit);
        decimal ConvertCentimetersToInches(decimal centimeters);
        decimal ConvertInchesToCentimeteres(decimal inches);
        decimal ConvertGramsToOunces(decimal grams);
        decimal ConvertOuncesToGrams(decimal ounces);
        decimal ConvertLitresToPints(decimal litres);
        decimal ConvertPintsToLitres(decimal centimeters);
    }
}
