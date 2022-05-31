namespace FluentInterface
{
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }

        public override string ToString() 
            => $"Name: {FullName}, Date of Birth: {DateOfBirth:G}, Department: {Department}, Address: {Address}";
    }
}