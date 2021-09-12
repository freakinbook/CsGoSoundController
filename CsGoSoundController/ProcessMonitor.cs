using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CsGoSoundController
{
	internal class ProcessMonitor
	{
		private bool ProcessExists { get; set; }
		private bool ProcessExisted { get; set; }
		public string ProcessName { get; set; }
		private List<ISubscriber> subscribers = new List<ISubscriber>();

		public ProcessMonitor(string processName)
		{
			ProcessName = processName;
		}

		public void AddSubscriber(ISubscriber subscriber)
		{
			subscribers.Add(subscriber);
		}

		public void Start()
		{
			Task t = Task.Run(async () =>
			{
				while (true)
				{
					ProcessExists = CheckIfProcessExists();
					if (ProcessExists != ProcessExisted)
					{
						Notify();
						ProcessExisted = ProcessExists;
					}
					await Task.Delay(10000);
				}
			});
			t.Wait();
		}

		private bool CheckIfProcessExists()
		{
			Process[] processes = Process.GetProcessesByName(ProcessName);
			if (processes.Length > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Notify()
		{
			foreach(var sub in subscribers)
			{
				sub.React(ProcessExists);
			}
		}
	}
}
