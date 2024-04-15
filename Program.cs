namespace ConsoleApp5
{
     class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();    
            student.Name = "Amar";
            student.Major = "CE";
            student.GPA = 3.8;
            student.PrintSummary();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine($"Name: {Name}, Major: {Major}, GPA: {GPA}");
        }

    }

    public class GraduateStudent : Student
    {
        public string ThesisTopic { get; set; }

        public void PrintGraduateSummary()
        {
            Console.WriteLine($"Name: {Name}, Major: {Major}, GPA: {GPA}, Topic: {ThesisTopic}");
        }
    }

}



