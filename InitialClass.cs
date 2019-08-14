using System;

namespace MainProject
{
	public class InitialClass
	{
		private readonly helloWorld;
		
		public InitialClass()
		{
			helloWorld = "Hello Worlds to Git!";
		}
		
		public ShowMainMessage = () => Console.WriteLine(helloWorld);
		
		public ShowAllMessages(string message, Action secondMessage)
		{
			Console.WriteLine(message);
			secondMessage;
			Cosnole.ReadKey();
		}
	}		
}