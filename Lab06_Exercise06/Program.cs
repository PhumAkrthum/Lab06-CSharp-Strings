﻿// See https://aka.ms/new-console-template for more information
var student = (firstname: "Phum", Lastname:"Akrthum", id: 66030270);
   // แก้ไข fname, lname และ id ให้เป็นข้อมูลของนักศึกษาเอง
   System.Console.WriteLine(
   @$"First name: {student.firstname} 
   Last name: {student.Lastname} 
   ID:{student.id}");
   
   int x = 3;
   int y = 4;
   System.Console.WriteLine($$"""Distance from origin to the point ({{x}},{{y}}) is {{Math.Sqrt(x*x+y*y)}}""");  
   
   System.Console.WriteLine("\n\nMethod to show { and } in string");
   System.Console.WriteLine($$"""Distance from origin to the point ({x},{y}) is {Math.Sqrt(x*x+y*y)}"""); 
