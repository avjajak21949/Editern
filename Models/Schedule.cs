using System;

namespace E_learning.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; } // Khóa chính
        public int ClassID { get; set; } // Khóa ngoại từ Class
        public Class Class { get; set; }
        public DateTime Date { get; set; } // Ngày học
        public string TimeSlot { get; set; } // Khung giờ học
        public bool IsOnline { get; set; } // Học online hay offline
    }

}
