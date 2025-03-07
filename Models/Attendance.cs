using System;
using System.Collections.Generic;

namespace E_learning.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; } // Khóa chính
        public int ScheduleID { get; set; } // Khóa ngoại từ Schedule
        public Schedule Schedule { get; set; }
        public int StudentID { get; set; } // Khóa ngoại từ Student
        public Student Student { get; set; }
        public bool Attend { get; set; } = false; // Trạng thái điểm danh (Có mặt, Vắng mặt)
        public DateTime AttendanceTime { get; set; } // Thời gian điểm danh
    }
}
