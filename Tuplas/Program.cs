

// var pt = (x:1, y:2);

// var slope = (double)pt.x / (double)pt.y;
// Console.WriteLine($"A line from the origin to the point {pt} has a slop of {slope}. ");

// pt.x = pt.x + 5;
// Console.WriteLine($"The point is at {pt}");

// var pt2 = pt with{y = 10};
// Console.WriteLine($"The point 'pt2' is at {pt2}");

// var subscript = (A:0, B:0);
// subscript = pt;
// Console.WriteLine(subscript);

// var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
// var person = (FirstName: "", LastName: "");
//var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

// Console.WriteLine(namedData.Name);
// Console.WriteLine(namedData.Item1);
// Console.WriteLine(namedData.Item2);
// person.FirstName = namedData.Name.Split(' ')[0];
// Console.WriteLine(person.FirstName);


// Point pt3 = new Point(1, 1);
// var pt4 = pt3 with { Y = 10};
// Console.WriteLine($"The two points are {pt3} and {pt4}");
// var pt5 = pt4;
// double slopResult = pt4.Slope();
// Console.WriteLine($" The slope of {pt4} is {slopResult}");
// Console.WriteLine(ReferenceEquals(pt4, pt5));



// public record struct Point(int X, int Y)
// {
//     public double Slope() => (double)Y / (double)X;
// }



// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Rafael";

// Pessoa pessoa2 = pessoa1;

// pessoa2.Nome = "Carlos";

// Console.WriteLine(pessoa1.Nome);

// // mude para class pessoa e observe que o pessoa1 e 2 irão apontar para mesma variavel
// record struct Pessoa
// {
//     public string Nome;
// }