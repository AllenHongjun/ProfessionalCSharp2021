﻿using System;
using System.Globalization;

if (args.Length != 1)
{
    ShowUsage();
    return;
}
switch (args[0])
{
    case "-n":
        NumberFormatDemo();
        break;
    case "-d":
        DateFormatDemo();
        break;
    default:
        ShowUsage();
        break;
}

void ShowUsage()
{
    Console.WriteLine("NumberAndDateFormatting command");
    Console.WriteLine("\tCommands:");
    Console.WriteLine("\t-n\tShow numbers");
    Console.WriteLine("\t-d\tShow dates");
}

void NumberFormatDemo()
{
    int val = 1234567890;

    // culture of the current thread
    Console.WriteLine(val.ToString("N"));

    // use IFormatProvider
    Console.WriteLine(val.ToString("N", new CultureInfo("fr-FR")));

    // change the culture of the thread
    CultureInfo.CurrentCulture = new CultureInfo("de-DE");

    Console.WriteLine(val.ToString("N"));
}

void DateFormatDemo()
{
    var d = new DateTime(2017, 09, 17);

    // current culture
    Console.WriteLine(d.ToString("D"));

    // use IFormatProvider
    Console.WriteLine(d.ToString("D", new CultureInfo("fr-FR")));

    // use current culture
    Console.WriteLine($"{CultureInfo.CurrentCulture}: {d:D}");

    CultureInfo.CurrentCulture = new("es-ES");
    Console.WriteLine($"{CultureInfo.CurrentCulture}: {d:D}");
}

