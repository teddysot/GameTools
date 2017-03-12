using System;

class HelloWorld
{
	static void Main()
	{
#if DebugCongig
		Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif
		Console.WriteLine("Hello World!");
	}
}