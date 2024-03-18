//using Geometry;
//using System.Globalization;

//int[] numbers1 = { 2, 5, 10, 12, 5, 1, 12, 2, 10, 11, 4 };
//int[] numbers2 = { 10, 1, 56, 7, 12, 1, 8, 5 , 1, 2, 2 };

#region Done
//Console.WriteLine(numbers1.Sum());
//Console.WriteLine(numbers1.Count());
//Console.WriteLine(numbers1.Min());
//Console.WriteLine(numbers1.Max());
//Console.WriteLine(numbers1.Average());

//var z = numbers1.Zip(numbers2);
//var z = numbers1.Union(numbers2);
//var z = numbers1.Intersect(numbers2);
//var z = numbers1.Concat(numbers2);
//var z = numbers1.Except(numbers2);

//var z = numbers1.Union(numbers2).Except(numbers1.Intersect(numbers2));
//var z = numbers1.Except(numbers2).Union(numbers2.Except(numbers1));
//var z = numbers1.Skip(3).Take(3);

//var z = numbers1.TakeWhile(x => x < 11);
//var z = numbers1.SkipWhile(x => x < 11);

//var z = numbers1.TakeLast(4);
//var z = numbers1.SkipLast(4);

//foreach (var item in z)
//{
//    Console.WriteLine(item);
//}

#endregion Done

//var chunks = numbers1.Chunk(3);
//foreach (var chunk in chunks)
//{
//	Console.WriteLine("Next chunk");
//	foreach (var element in chunk)
//	{
//		Console.WriteLine(element);
//	}
//}

//Console.WriteLine(numbers1.SequenceEqual(numbers2));
//Console.WriteLine(numbers1.SequenceEqual(numbers1));

//var y = numbers1.All(x => x > 0);
//var y = numbers1.Any(x => x > 50);
//Console.WriteLine(y);

//string[] names = { "James", "Bob", "Sam", "Keanu", "Adam" };
//Console.WriteLine(names.OrderByDescending(x => x.Length).First().Length);
//Console.WriteLine(names.MaxBy(x=>x.Length).Length);


//var pc = new PolygonalChain(new Point(1, 1), new Point(5, 8));
//pc.AddMidpoint(new Point(1, 2));
//pc.AddMidpoint(new Point(1, 3));
//pc.AddMidpoint(new Point(1, 4));
//pc.AddMidpoint(new Point(1, 5));

////foreach(var point in pc)
////    Console.WriteLine(point);

//Console.WriteLine(pc.First());
//Console.WriteLine(pc.Last());

