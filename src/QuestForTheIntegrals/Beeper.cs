using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Quest_For_The_Integrals
{
	public static class Beeper
	{
		static int _period = 0;

		/// <summary>
		/// Replaces Console.Beep to improve sound quality.
		/// </summary>
		public static void Beep(int frequency, int duration)
		{
			//Console.Beep(frequency, duration);

			Beep(100, frequency, duration);
		}

		private static void Beep(int amplitude, int frequency, int duration)
		{
			double A = ((amplitude * (System.Math.Pow(2, 15))) / 1000) - 1;
			double DeltaFT = 2 * Math.PI * frequency / 44100.0;

			int Samples = 441 * duration / 10;
			int Bytes = Samples * 4;
			int[] Hdr = { 0X46464952, 36 + Bytes, 0X45564157, 0X20746D66, 16, 0X20001, 44100, 176400, 0X100004, 0X61746164, Bytes };
			using (MemoryStream MS = new MemoryStream(44 + Bytes))
			{
				using (BinaryWriter BW = new BinaryWriter(MS))
				{
					for (int i = 0; i < Hdr.Length; i++)
					{
						BW.Write(Hdr[i]);
					}
					for (int t = 0; t < Samples; t++)
					{
						++_period;
						short Sample = System.Convert.ToInt16(A * Math.Sin(DeltaFT * _period));
						BW.Write(Sample);
						BW.Write(Sample);
					}
					BW.Flush();
					MS.Seek(0, SeekOrigin.Begin);
					using (SoundPlayer SP = new SoundPlayer(MS))
					{
						SP.PlaySync();
					}
				}
			}
		}
	}
}
