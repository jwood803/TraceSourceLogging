namespace TraceSourceLogging
{
    using System.Diagnostics;

    class Program
    {
        private static TraceSource traceSource = new TraceSource("Log");

        static void Main(string[] args)
        {
            traceSource.TraceInformation("Creating new person");

            var person = new Person
            { 
                FirstName = "John",
                LastName = "Doe"
            };

            traceSource.TraceInformation("Creating new employee");

            var employee = new Employee
            {
                Department = "IT",
                FirstName = person.FirstName,
                LastName = person.LastName,
                Manager = new Person
                {
                    FirstName = "Jane",
                    LastName = "Doe"
                }                
            };

            person.IsValid();

            employee.IsDepartmentValid();

            traceSource.Flush();
            traceSource.Close();
        }
    }
}