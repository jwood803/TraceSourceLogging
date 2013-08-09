namespace TraceSourceLogging
{
    using System.Diagnostics;

    class Program
    {
        private static TraceSource traceSource = new TraceSource("Log");

        static void Main(string[] args)
        {
            traceSource.TraceData(TraceEventType.Verbose, 1, "Now we're logging!");
            traceSource.Flush();
            traceSource.Close();
        }
    }
}