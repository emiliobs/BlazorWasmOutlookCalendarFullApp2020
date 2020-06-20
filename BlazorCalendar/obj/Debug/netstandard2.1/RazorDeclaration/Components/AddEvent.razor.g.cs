#pragma checksum "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\Components\AddEvent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e292d457c8c0f609261083488336c44cef6399"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCalendar.Components
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using BlazorCalendar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    public partial class AddEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Projects3\BlazorWasmOutlookCalendarFullApp2020-1\BlazorCalendar\Components\AddEvent.razor"
 
	[Parameter]
	public CalendarDay SelectedDay { get; set; }
	private CalendarEvent model = new CalendarEvent();

	private void AddEventToSelectedDay()
	{

		//Convert the time to the a new date date within the selected day.
		model.StartDate = new DateTime(SelectedDay.Date.Year, SelectedDay.Date.Month, SelectedDay.Date.Day, model.StartDate.Hour,
																													model.StartDate.Minute, 0);

		model.EndDate = new DateTime(SelectedDay.Date.Year, SelectedDay.Date.Month, SelectedDay.Date.Day, model.EndDate.Hour,
																												model.EndDate.Minute, 0);

		if (SelectedDay.Events == null)
			SelectedDay.Events = new List<CalendarEvent>();

		SelectedDay.Events.Add(new CalendarEvent
		{
			Subject = model.Subject,
			StartDate = model.StartDate,
			EndDate = model.EndDate
		});

		Console.WriteLine($"Total Events in Day { SelectedDay.Events.Count } | {model.Subject } | {  model.StartDate } | {model.EndDate}");
		model = new CalendarEvent();
		//TODO: Push the event to the API
		OnEventAdded();
	}

public static event Action OnEventAdded = () => 
{

	 
};


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
