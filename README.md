# Imperial-Metric-Converter

#	Packages installed	Version
1	netcoreapp3.1	      3.1
2	Dapper	            2.0.123
3	Microsoft.Data.SqlClient	5.0.1
4	Microsoft.NET.Test.Sdk	17.1.0
5	Moq 	                4.18.2
6	xunit               	2.4.1

#Database file: Converter_Script.sql 
Contains DDL and DML definitions for tables used in the project.
1.	tblConversionRates
2.	log

#Conversion Type	API
1	Celsius To Fahrenheit	 api/conversion/CelsiousToFahrenheit/{id}
2	Fahrenheit to Celsius	api/conversion/ FahrenheitToCelsious/{id}
3	Centimeters to inches	api/conversion/CentimetersToInches/{id}
4	inches to Centimeters	api/conversion/ InchesToCentimeteres /{id}
5	Grams To Ounces	      api/conversion/ GramsToOunces/{id}
6	Ounces To Grams	      api/conversion/ OuncesToGrams /{id}
7	Litres To Pints	      api/conversion/ LitresToPints/{id}
8	PintsToLitres	        api/conversion/ PintsToLitres /{id}

#Api Call Examples:
https://localhost:44341/api/conversion/FahrenheitToCelsious/15 
https://localhost:44341/api/conversion/CelsiousToFahrenheit/15
https://localhost:44341/api/conversion/PintsToLitres/15 
https://localhost:44341/api/conversion/LitresToPints/15 
https://localhost:44341/api/conversion/OuncesToGrams/15 
https://localhost:44341/api/conversion/GramsToOunces/15 
https://localhost:44341/api/conversion/InchesToCentimeteres/15 
https://localhost:44341/api/conversion/CentimetersToInches/15 

Input:
Example: 15
Output:  
Example: 59.0000






