using Imperial_Metric_Converter.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Imperial_Metric_Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {

        private readonly IConversionService _conversionService;
        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpGet]
        [Route("CelsiousToFahrenheit/{id}")]
        public decimal CelsiousToFahrenheit(decimal id)
        {
            return _conversionService.ConvertCelsiousToFahrenheit(id);
        }
        [HttpGet]
        [Route("FahrenheitToCelsious/{id}")]
        public decimal FahrenheitToCelsious(decimal id)
        {
            return _conversionService.ConvertFahrenheitToCelsious(id);
        }
        [HttpGet]
        [Route("CentimetersToInches/{id}")]
        public decimal CentimetersToInches(decimal id)
        {
            return _conversionService.ConvertCentimetersToInches(id);
        }
        [HttpGet]
        [Route("InchesToCentimeteres/{id}")]
        public decimal InchesToCentimeteres(decimal id)
        {
            return _conversionService.ConvertInchesToCentimeteres(id);
        }
        [HttpGet]
        [Route("GramsToOunces/{id}")]
        public decimal GramsToOunces(decimal id)
        {
            return _conversionService.ConvertGramsToOunces(id);
        }
        [HttpGet]
        [Route("OuncesToGrams/{id}")]
        public decimal OuncesToGrams(decimal id)
        {
            return _conversionService.ConvertOuncesToGrams(id);
        }
        [HttpGet]
        [Route("LitresToPints/{id}")]
        public decimal LitresToPints(decimal id)
        {
            return _conversionService.ConvertLitresToPints(id);
        }
        [HttpGet]
        [Route("PintsToLitres/{id}")]
        public decimal PintsToLitres(decimal id)
        {
            return _conversionService.ConvertPintsToLitres(id);
        }
    }
}
