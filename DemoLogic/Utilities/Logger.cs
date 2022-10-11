using System;
namespace DependencyInjection_Autofac.Utilities
{
	public class Logger
	{
        public void Log(string message)
        {
            Console.WriteLine($"Logging {message}");
        }
    }
}

