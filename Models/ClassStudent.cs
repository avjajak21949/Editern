namespace E_learning.Models
{
    public class ClassStudent
    {
        public int ClassStudentId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ClassID { get;set; }
        public Class Class { get; set; }
    }
}
