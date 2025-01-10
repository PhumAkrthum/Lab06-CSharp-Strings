// See https://aka.ms/new-console-template for more information
//System.Text.StringBuilder sb = new System.Text.StringBuilder("Rat is my favorite animal.");
       
//System.Console.WriteLine(@$"Before change : sb = {sb.ToString()}, 
//sb.GetHashCode = {sb.GetHashCode()}");
       
//System.Console.WriteLine(@"Replace first char in sb  from R to C");
//sb[0] = 'C';
       
//System.Console.WriteLine(@$"After change : sb = {sb.ToString()}, 
//sb.GetHashCode = {sb.GetHashCode()}");

       var sb = new System.Text.StringBuilder();
       
       // Create a string composed of numbers 0 - 9
       for (int i = 0; i < 10; i++)
       {
           System.Console.Write ($"Loop {i+1, 2} : ");
           sb.Append(i.ToString());
           System.Console.WriteLine($"sb = {sb.ToString(),-11}, sb.GetHashCode() = {sb.GetHashCode()}");
       }
       Console.WriteLine($"Finally : sb = {sb}");  
