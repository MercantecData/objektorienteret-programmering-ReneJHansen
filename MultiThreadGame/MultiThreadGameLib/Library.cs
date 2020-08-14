using System;
using System.Threading.Tasks;


namespace MultiThreadGameLib
{
    public delegate Task TickCounter(int seconds);
    public class Library
    {
        public Task CreateWriteTimer(int seconds)
        {
            Task task = new Task(() =>
            {
                for (int i = 10; i > 0; i--)
                {
                    Task.Delay(seconds * 1000).Wait();
                    Console.WriteLine($"Time left: {i} sec");
                }
                Console.WriteLine("Time is up");
            });
            task.Start();
            return task;
        }
    }
}
