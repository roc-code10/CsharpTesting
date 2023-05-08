using System.Globalization;

WriteLine("Hello, World, console app 1!");

const int number = 10;
var favoriteNumber = "My favorite number is";
WriteLine(favoriteNumber + " " + number);

var double1 = 2.5;
var double2 = 0.5;
var sum = double1 + double2;
WriteLine(sum.ToString("0.00"));
WriteLine(sum.ToString("C3", CultureInfo.CreateSpecificCulture("ro-RO")));
WriteLine(sum.ToString("P"));

var int1 = 55;
var int2 = 10;
var division = int1 / int2;
var divisionDouble = (double) int1 / int2;
WriteLine(division);
WriteLine(divisionDouble);

var dateUtc = DateTime.UtcNow;
WriteLine(dateUtc);

var date = DateTime.Now;
WriteLine(date);
