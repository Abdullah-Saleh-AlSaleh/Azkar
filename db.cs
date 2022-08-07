using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTimers
    {
        public class db
        {

            public static List<Notification> GetData()
            {
                int Year = DateTime.Now.Year;
                int Month = DateTime.Now.Month;
                int Day = DateTime.Now.Day;
                int Hour = DateTime.Now.Hour;

                DateTime dt1 = new DateTime(Year, Month, Day, Hour, 00, 00);

                 string title  = " أذكار";
                string test = @"لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلِّ شَيْءِ قَدِيرِ."+ " سُبْحـانَ اللهِ وَبِحَمْـدِهِ."+ "أسْتَغْفِرُ اللهَ وَأتُوبُ إلَيْهِ"+ " رَضيـتُ بِاللهِ رَبَّـاً وَبِالإسْلامِ ديـناً وَبِمُحَـمَّدٍ صلى الله عليه وسلم نَبِيّـا.";





                var Notification = new List<Notification>()
            {
                 new Notification(){Id=1,Text=test,Title=title,Date=dt1},
          




            };
                return Notification.ToList();
            }
        }
        public class Notification
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public DateTime Date { get; set; }

        }

   
    }

