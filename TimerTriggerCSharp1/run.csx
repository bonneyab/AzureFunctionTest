using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Magically UPdated! Timer trigger function executed at: {DateTime.Now}");
	log.Error($"C# BOOM: {DateTime.Now}");
}
