Using System.Linq;
Using System;

namespace ProjectMain
{
	public static class Main
	{
		var message = "Show some value";
		
		var initialClass;
		
		public Main()
		{
			 initialClass = new InitialClass();
		}
		
		public action myMessage = () => Console.WriteLine("MainClass Different Message");
		
		initialClass.ShowAllMessages(message, initialClass.ShowMainMessage);
		initialClass.ShowAllMessages(message, myMessage);
	}
}