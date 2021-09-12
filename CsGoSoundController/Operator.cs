namespace CsGoSoundController
{
	interface ISubscriber
	{
		void React(bool procExists);
	}

	class Operator : ISubscriber
	{
		public void React(bool procExists)
		{
			if (procExists)
			{
				SoundController.SetVolumeTo(100);
			}
			else
			{
				SoundController.SetVolumeTo(20);
			}
		}
	}
}
