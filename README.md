# H2OLib

H2OLib is a collection of .NET functionality to make programming common tasks cleaner and easier. The main purpose is to ease day-to-day programming.

## Enums
Example enum...
``` c#
public enum MetricUnits
{
	[Description("mm")] //using System.ComponentModel.Description
	Millimeters = 1,
	[Description("cm")]
	Centimeters = 2,
	[Description("m")]
	Meters = 3,
	[Description("km")]
	Kilometers = 4,
	[Description("mg")]
	Milligrams = 5,
	Centigrams = 6,
	//... And so on...	
}
```


In cases where you might want to tack on a human readable string to your enum values (display values):
``` c#
using H2OLib.Extensions;

public string doSomething(){
	Console.WriteLine(MetricUnits.Millimeters.GetDescription())
	//mm
	
	Console.WriteLine(MetricUnits.Centigrams.GetDescription()) //(no description applied will output the enum member's name)
	//Centrigrams 
}
```



Converting integers back to Enums:
``` c#
using H2OLib.Extensions;

//supported types: byte, sbyte, short, ushort, uint, int, ulong, long

int metricUnit1 = 3;
MetricUnits mu1 = metricUnit1.ToEnum<MetricUnits>(); //mu1 = MetricUnits.Meters

int metricUnit2 = 0; //value not in enum...
MetricUnits mu2 = metricUnit2.ToEnum<MetricUnits>(); //throws ArgumentException

```

Converting strings back to Enums:
``` c#
using H2OLib.Extensions;

string metricUnit1 = "3";
MetricUnits mu1 = metricUnit1.ToEnum<MetricUnits>(); //mu1 = MetricUnits.Meters

string metricUnit2 = "Kilometers";
MetricUnits mu2 = metricUnit2.ToEnum<MetricUnits>(); //mu2 = MetricUnits.Kilometers

string metricUnit3 = "0"; //value not in enum...
MetricUnits mu3 = metricUnit3.ToEnum<MetricUnits>(); //throws ArgumentException

string metricUnit4 = "kilometers"; //value not an exact match (value not in enum...)
MetricUnits mu4 = metricUnit4.ToEnum<MetricUnits>(); //throws ArgumentException
```

Converting objects back to Enums:
``` c#
using H2OLib.Extensions;

object metricUnit1 = 1;
MetricUnits mu1 = metricUnit1.ToEnum<MetricUnits>(); //mu1 = MetricUnits.Millimeters

object metricUnit2 = "1";
MetricUnits mu2 = metricUnit2.ToEnum<MetricUnits>(); //mu2 = MetricUnits.Millimeters

object metricUnit3 = 0; //value not in enum...
MetricUnits mu3 = metricUnit3.ToEnum<MetricUnits>(); //throws ArgumentException

object metricUnit4 = "0"; //value not in enum...
MetricUnits mu4 = metricUnit4.ToEnum<MetricUnits>(); //throws ArgumentException

object metricUnit5 = "Millimeters";
MetricUnits mu5 = metricUnit5.ToEnum<MetricUnits>(); //mu5 = MetricUnits.Millimeters

object metricUnit6 = "millimeters"; //value not an exact match (value not in enum...)
MetricUnits mu6 = metricUnit6.ToEnum<MetricUnits>(); //throws ArgumentException
```