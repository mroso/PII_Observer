using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureReporter reporter = new TemperatureReporter();
            reporter.StartReporting(monitor);
            monitor.GetTemperature();
        }
    }
}