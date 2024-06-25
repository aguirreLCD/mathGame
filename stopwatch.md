'''

async <type> CountDown()
{
// STOPWATCH
// var stopWatch = new Stopwatch();
// stopWatch.Start();
var stopWatch = Stopwatch.StartNew();
// var startTime = Stopwatch.GetTimestamp();
await Task.Delay(3000);
// var endTime = Stopwatch.GetTimestamp();
// var interval = Stopwatch.GetElapsedTime(startTime, endTime);
// stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed.Seconds);
// Console.WriteLine(stopWatch.ElapsedMilliseconds);
// Console.WriteLine(stopWatch.ElapsedTicks);
// Console.WriteLine(interval);

}
// CountDown();
[ ] Add a timer (countdown) to track how long the user takes to finish the game;
var stopWatch = Stopwatch.StartNew();
await Task.Delay(3000);
stopWatch.Stop();
Console.WriteLine(stopWatch.Elapsed.Seconds); -->

'''
