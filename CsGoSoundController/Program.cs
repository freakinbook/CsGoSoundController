namespace CsGoSoundController
{
	class Program
	{
		static void Main(string[] args)
		{
			ProcessMonitor pm = new ProcessMonitor("csgo");
			Operator op = new Operator();
			pm.AddSubscriber(op);
			pm.Start();
		}
	}
}
