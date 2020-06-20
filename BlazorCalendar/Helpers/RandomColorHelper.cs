using System;

namespace BlazorCalendar.Helpers
{
    public class RandomColorHelper
    {
        private static Random random = new Random();
				private static string[] colorClasses = new [] {"yellow","red","pink-red","magenta","green"};


				public static string GetRandomColorClass()
				{
					return colorClasses[random.Next(0, colorClasses.Length)];
				}
    }
}