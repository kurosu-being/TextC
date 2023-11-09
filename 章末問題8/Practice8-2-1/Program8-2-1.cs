using System;

namespace Practice8_2_1 {
    class Program {
        static void Main(string[] args) {
            var today = DateTime.Today;
            DateTime nextWeekFriday = NextWeek(today, DayOfWeek.Friday);
            Console.WriteLine(nextWeekFriday);
        }
        public static DateTime NextWeek(DateTime vDate, DayOfWeek vDayOfWeek) {
            int wDaysSpan = ((int)vDayOfWeek - (int)vDate.DayOfWeek + 7) % 7;
            return vDate.AddDays(wDaysSpan + 7);
        }
    }
}
//            var wToday = DateTime.Today;
//            DateTime NextWeekWednesDay = NextWeek(wToday, DayOfWeek.Friday);
//            Console.WriteLine(NextWeekWednesDay);
//        }
//        public static DateTime NextWeek(DateTime vDate, DayOfWeek vDayOfWeek){
//            if ((int)vDayOfWeek - (int)(vDate.DayOfWeek) >= 0) {
//            var wDays = (int)vDayOfWeek - (int)(vDate.DayOfWeek);
//            if (wDays <= 0){
//               wDays += 7;
//            } else {
//                wDays += 14;
//                }
//            return vDate.AddDays(wDays);
//            }

//        }
//    }
//}
