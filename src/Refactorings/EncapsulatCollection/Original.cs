namespace EncapsulatCollection.Original
{
    public class Student
    {
        public string Name { get;set; }
        public int Age { get;set; }
    }

    public class ClassRoom
    {
        public List<Student> Students;
        public ClassRoom()
        {
            Students = new List<Student>();
            Students.Add(new Student { Age = 12, Name = "Tom" });
            Students.Add(new Student { Age = 13, Name = "Jerry" });
        }
    }
    public class Example
    {
        /**
         * In this example, the collection is not encapsulated
         * You can modify it directly
         * You can retrieve the original collection and add/remove elements to it
         **/
        public static void Main(string[] args)
        {
            var classRoom = new ClassRoom();

            //you can get access to the collection directly
            var students = classRoom.Students;
            DisplayStudents(students);

            //and modify it
            students.RemoveAt(0);
            students.Add(new Student { Age = 12, Name = "Jane"});

            //you can directly change the collection
            classRoom.Students = new List<Student>();
        }

        private static void DisplayStudents(List<Student> students)
        {
            //...
        }
    }
}
