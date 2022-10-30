using Imperial_Metric_Converter.Interfaces;
using Imperial_Metric_Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imperial_Metric_Converter.Services
{
    public class ConversionService : IConversionService
    {
        private readonly IConversionRepository _conversionRepository;
        private readonly IErrorLoggingService _errorLoggingService;
        private IEnumerable<UnitConversion> conversionRates;
        public ConversionService(IConversionRepository conversionRepository, IErrorLoggingService errorLoggingService)
        {
            _conversionRepository = conversionRepository;
            _errorLoggingService = errorLoggingService;
            conversionRates = _conversionRepository.GetUnitConversionRates().Result;
        }
        public decimal ConvertCelsiousToFahrenheit(decimal celsious)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "Celsius_to_Fahrenheit").SingleOrDefault().ConversionRate;
                result = celsious * rate + 32;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;
        }
        public decimal ConvertFahrenheitToCelsious(decimal Fahrenheit)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "Fahrenheit_to_Celsius").SingleOrDefault().ConversionRate;
                result = Fahrenheit - 32 * rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;

        }
        public decimal ConvertCentimetersToInches(decimal centimeters)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "CM_Inches").SingleOrDefault().ConversionRate;
                result = centimeters / rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;

        }



        public decimal ConvertInchesToCentimeteres(decimal inches)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "CM_Inches").SingleOrDefault().ConversionRate;
                result = inches * rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;


        }
        public decimal ConvertGramsToOunces(decimal grams)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "ounces_Grams").SingleOrDefault().ConversionRate;
                result = grams / rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;

        }

        public decimal ConvertOuncesToGrams(decimal ounces)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "ounces_Grams").SingleOrDefault().ConversionRate;
                result = ounces * rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;

        }
        public decimal ConvertLitresToPints(decimal litres)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "litres_Pints").SingleOrDefault().ConversionRate;
                result = litres * rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;
        }

        public decimal ConvertPintsToLitres(decimal pints)
        {
            decimal rate = 0;
            decimal result = 0;
            try
            {
                rate = conversionRates.Where(x => x.ConversionType == "litres_Pints").SingleOrDefault().ConversionRate;
                result = pints / rate;
            }
            catch (Exception ex)
            {
                _errorLoggingService.LoggingError(ex);
            }
            return result;

        }



    }
}
