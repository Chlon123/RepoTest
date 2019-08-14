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
		
		public void ShowMainMessage()
		{
			Console.WriteLine(helloWorld);
		}
	}		
}