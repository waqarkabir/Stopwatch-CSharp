// See https://aka.ms/new-console-template for more information
#region Microsoft Implementation Provided
//using System.Diagnostics;

//Console.WriteLine("Stopwatch by Waqar Kabir");
//Stopwatch stopwatch = new Stopwatch();
//Console.WriteLine("Press any key to start Stopwatch time");
//Console.ReadKey();
//Console.WriteLine("");
//stopwatch.Start();
//DateTime startTime= DateTime.Now;
//Console.WriteLine("Time started");
//Console.WriteLine("Press any key to stop Stopwatch time");
//Console.ReadKey();
//Console.WriteLine("");
//stopwatch.Stop();
//DateTime endTime = DateTime.Now;
//TimeSpan timeDiff = endTime - startTime;
//Console.WriteLine("Calculated time lapsed is: " + timeDiff);

#endregion

#region Implemented by Waqar Kabir

//Console.WriteLine("Stopwatch by Waqar Kabir");
//Stopwatch stopwatch = new Stopwatch();
//Console.WriteLine("Press any key to start Stopwatch time");
//Console.ReadKey();
//Console.WriteLine("");
//Console.WriteLine("Time started");
//Console.WriteLine("Press any key to stop Stopwatch time");
//Console.ReadKey();
//Console.WriteLine("");
//stopwatch.Stop();
//Console.WriteLine("Calculated time lapsed is: " + stopwatch.Elapsed.ToString());

#endregion
using Models;

StopWatch stopWatch = new StopWatch();

Console.WriteLine("Press any key to start Stopwatch time");
Console.ReadKey();

Console.WriteLine("");
stopWatch.Start();

Console.WriteLine("Time started");
Console.WriteLine("Press any key to stop Stopwatch time");

Console.ReadKey();
Console.WriteLine("");

stopWatch.Stop();
Console.WriteLine("Calculated time lapsed is: " + stopWatch.TimeTook());
