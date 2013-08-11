using System.Diagnostics;
namespace TraceSourceLogging
{
    public class Employee : Person
    {
        private static readonly TraceSource traceSource = new TraceSource("EmployeeLog");

        public string Department { get; set; }
        public Person Manager { get; set; }
        public bool IsActive { get; set; }

        public bool IsDepartmentValid()
        {
            var isValid = !string.IsNullOrWhiteSpace(this.Department);
            traceSource.TraceInformation(string.Format("Is the {0} department valid - {1}", this.Department, isValid));
            return isValid;
        }
    }
}