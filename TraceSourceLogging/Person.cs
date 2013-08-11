namespace TraceSourceLogging
{
    using System.Diagnostics;

    public class Person
    {
        private static readonly TraceSource traceSource = new TraceSource("PersonLog");

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsValid()
        {
            var isValid = (!string.IsNullOrWhiteSpace(this.FirstName) || !string.IsNullOrWhiteSpace(this.LastName));
            traceSource.TraceInformation(string.Format("Is {0} {1} valid - {2}", this.FirstName, this.LastName, isValid));
            return isValid;
        }
    }
}