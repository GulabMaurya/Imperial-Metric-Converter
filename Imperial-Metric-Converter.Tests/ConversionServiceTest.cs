using System;
using Xunit;
using Imperial_Metric_Converter.Services;
using Moq;
using Imperial_Metric_Converter.Interfaces;
using Imperial_Metric_Converter.Controllers;

namespace Imperial_Metric_Converter.Tests
{
    public class ConversionServiceTest
    {

        public Mock<IConversionService> convsersionServiceMoq = new Mock<IConversionService>();


        [Fact]
        public void Should_Convert_Celsious_Fahrenheit()
        {
            convsersionServiceMoq.Setup(p => p.ConvertCelsiousToFahrenheit(1)).Returns(33.8M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.CelsiousToFahrenheit(1);
            Assert.Equal(33.8M, result);
        }
        [Fact]
        public void Should_Convert_Fahrenheit_Celsious()
        {
            convsersionServiceMoq.Setup(p => p.ConvertFahrenheitToCelsious(50)).Returns(10);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.FahrenheitToCelsious(50);
            Assert.Equal(10, result);
        }
        [Fact]
        public void Should_Convert_Centimeters_Inches()
        {
            convsersionServiceMoq.Setup(p => p.ConvertCentimetersToInches(2.54M)).Returns(1);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.CentimetersToInches(2.54M);
            Assert.Equal(1, result);
        }
        [Fact]
        public void Should_Convert_Inches_Centimeters()
        {
            convsersionServiceMoq.Setup(p => p.ConvertInchesToCentimeteres(1)).Returns(2.54M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.InchesToCentimeteres(1);
            Assert.Equal(2.54M, result);
        }
        [Fact]
        public void Should_Convert_Litres_Pints()
        {
            convsersionServiceMoq.Setup(p => p.ConvertLitresToPints(10)).Returns(21.1338M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.LitresToPints(10);
            Assert.Equal(21.1338M, result);
        }
        [Fact]
        public void Should_Convert_Pints_Litres()
        {
            convsersionServiceMoq.Setup(p => p.ConvertPintsToLitres(15)).Returns(7.09765M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.PintsToLitres(15);
            Assert.Equal(7.09765M, result);
        }
        [Fact]
        public void Should_Convert_Grams_Ounces()
        {
            convsersionServiceMoq.Setup(p => p.ConvertGramsToOunces(100)).Returns(3.5274M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.GramsToOunces(100);
            Assert.Equal(3.5274M, result);
        }
        [Fact]
        public void Should_Convert_Ounces_Grams()
        {
            convsersionServiceMoq.Setup(p => p.ConvertOuncesToGrams(100)).Returns(2834.95M);
            ConversionController con = new ConversionController(convsersionServiceMoq.Object);
            decimal result = con.OuncesToGrams(100);
            Assert.Equal(2834.95M, result);
        }
    }
}
