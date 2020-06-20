namespace BlazorCalendar.Models
{
    public class CalendarEventViewModel: CalendarEvent
    {
        public CalendarEventViewModel()
				{
						Color = Helpers.RandomColorHelper.GetRandomColorClass();
				}
    }
}