using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace kalendarForms
{
    class MainViewModel
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();

        public MainViewModel()
        {
            CalendarInlineEvent event1 = new CalendarInlineEvent();
            event1.StartTime = new DateTime(2024, 4, 25, 5, 0, 0);
            event1.EndTime = new DateTime(2024, 4, 25, 7, 0, 0);
            event1.Subject = "Odevzdání úkolu";
            event1.Color = Color.Red;

            CalendarInlineEvent event2 = new CalendarInlineEvent();
            event2.StartTime = new DateTime(2024, 4, 26, 10, 0, 0);
            event2.EndTime = new DateTime(2024, 4, 26, 12, 0, 0);
            event2.Subject = "Nástup do Nové práce";
            event2.Color = Color.Green;

            CalendarInlineEvents.Add(event1);
            CalendarInlineEvents.Add(event2);
        }
    }
}
