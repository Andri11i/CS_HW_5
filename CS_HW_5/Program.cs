
// 1

using CS_HW_5;

Thermostat thermostat = new Thermostat();
thermostat.TemperatureChanged += (newTemp) =>
{
    Console.WriteLine($"Temperature changed to: {newTemp}°C");
};

thermostat.Temperature = 25.0;
thermostat.Temperature = 30.0;


// 2


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
Console.Write("Enter a number to filter greater than: ");
int filterValue = int.Parse(Console.ReadLine());
var greaterNumbers = numbers.Where(n => n > filterValue).ToList();
Console.WriteLine($"Numbers greater than {filterValue}: " + string.Join(", ", greaterNumbers));


// 3


int[] numbers1 = { 1, 2, 3, 4, 5 };
int[] numbers2 = { 10, 20, 30 };

Console.WriteLine($"Average of array 1: {numbers1.Average()}");
Console.WriteLine($"Average of array 2: {numbers2.Average()}");


// 4


Sensor sensor = new Sensor();
sensor.MeasurementUpdated += (average) =>
{
    Console.WriteLine($"Average measurement: {average}");
};

sensor.AddMeasurement(25.5);
sensor.AddMeasurement(30.0);
sensor.AddMeasurement(-5.0);  // не добавится
sensor.AddMeasurement(40.5);