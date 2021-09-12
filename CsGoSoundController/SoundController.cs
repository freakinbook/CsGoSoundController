using AudioSwitcher.AudioApi.CoreAudio;

namespace CsGoSoundController
{
	static class SoundController
	{
		private static CoreAudioDevice defaultAudio;

		static SoundController()
		{
			defaultAudio = new CoreAudioController().DefaultPlaybackDevice;
		}

		public static void SetVolumeTo(int level)
		{
			defaultAudio.Volume = level;
		}
	}
}
