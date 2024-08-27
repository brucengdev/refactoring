namespace EncapsulatCollection.Refactored
{
    /**
     * The refactored version
     * - Return a copy of the collection to avoid unexpected modification.
     * - Add modifier functions to modify the collection that are encapsulated.
     * These totally help to protect the collection from being modified unexpectedly.
     **/ 
    public class Student
    {
        public string Name { get;set; }
        public int Age { get;set; }

        public Student Clone()
        {
            return new Student { Name = this.Name, Age = this.Age };
        }
    }

    public class ClassRoom
    {
        private List<Student> _students;
        public ClassRoom()
        {
            _students = new List<Student>();
            _students.Add(new Student { Age = 12, Name = "Tom" });
            _students.Add(new Student { Age = 13, Name = "Jerry" });
        }

        public List<Student> GetStudents()
        {
            //Clone the list of students to avoid unexpected modification
            return _students.Select(student => student.Clone()).ToList();
        }

        public void SetStudents(List<Student> newStudents)
        {
            _students = newStudents;
        }

        public void RemoveAt(int index)
        {
            _students.RemoveAt(index);
        }

        public void AddStudent(Student newStudent)
        {
            _students.Add(newStudent.Clone());
        }
    }
    public class Example
    {
        /**
         * 
         **/
        public static void Main(string[] args)
        {
            var classRoom = new ClassRoom();

            //you can get access to the collection directly
            var students = classRoom.GetStudents();
            DisplayStudents(students);

            //and modify it
            classRoom.RemoveAt(0);
            classRoom.AddStudent(new Student { Age = 12, Name = "Jane"});

            //you can directly change the collection
            classRoom.SetStudents(new List<Student>());
        }
        private static void DisplayStudents(List<Student> students)
        {
            //...
        }
    }
}
