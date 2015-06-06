using System;
using System.Text;

namespace HomePractice
{
	public class ClockTopCoder
	{
		public ClockTopCoder ()
		{

		}

		/// <summary>
		/// Whats the time.
		/// </summary>
		/// <returns>The time.</returns>
		/// <param name="time">Time.</param>
		public string whatTime(int time)
		{
			int hours = time / 3600;
			int minutes = (time % 3600) / 60;
			int seconds = (time % 3600) % 60;
			StringBuilder sb = new StringBuilder ();
			sb.Append (hours.ToString());
			sb.Append(':');
			sb.Append (minutes.ToString());
			sb.Append(':');
			sb.Append(seconds.ToString());
			return sb.ToString ();
		}
	}
}

