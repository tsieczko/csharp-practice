using static System.Console;

namespace Packt.Shared
{
	public interface IPlayable
	{
		void Play();

		void Pause();

		// default interface C# 8.0+ netstandard2.1
		void Stop()
		{
			WriteLine("Default implementation of Stop.");
		}
	}
}
