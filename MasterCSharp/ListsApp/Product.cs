

namespace ListsApp
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA) {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
