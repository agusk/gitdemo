﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// ini benar
Console.WriteLine("Hello, World! 3");
Console.WriteLine("Hello, World! 3");
Console.WriteLine("Hello, World! 3");
// ini yang benar
Console.WriteLine("Hello, World! 3");

Product o = new Product{Id=1, Name="Product 1", Description="Product 1 Description", Price=1000, Category="Category 1"};

Console.WriteLine(o.Id);

Console.WriteLine(o.Name);


Shop f = new Shop{Name="Shop 1", Address="Address 1", City="City 1"};