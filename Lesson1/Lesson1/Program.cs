//7.1
ACoder aCoder1 = new("Виктор");
Console.WriteLine(aCoder1.Decode());
Console.WriteLine(aCoder1.Encode());

BCoder bCoder1 = new("АндРей");
Console.WriteLine(bCoder1.Decode());
Console.WriteLine(bCoder1.Encode());


//7.2
Figure figure = new Figure();
Console.WriteLine(figure);


Point point1 = new Point(1, 2);
point1.MoveForX(1, 2);
point1.FigureColor = Figure.Color.red;
point1.FigureVisibility = Figure.Visibility.invisible;
Console.WriteLine(point1);

Circle circle1 = new(1, 1, 20);
Console.WriteLine(circle1.GetSquare());

Rectangle rectangle1 = new(1, 1, 10, 15);
Console.WriteLine(rectangle1.GetSquare());




Console.ReadKey(true);


