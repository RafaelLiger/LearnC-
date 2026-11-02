string sayHello = "Hello World!";
Console.WriteLine(sayHello.ToUpper());
sayHello = sayHello.Replace("Hello", "Nice");
string sayHello2 = sayHello.Trim();
Console.WriteLine($"{sayHello2.ToLower()}");