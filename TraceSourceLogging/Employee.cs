// -----------------------------------------------------------------------
// <copyright file="Employee.cs" company="">
// </copyright>
// -----------------------------------------------------------------------
namespace TraceSourceLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Employee : Person
    {
        public string Department { get; set; }
        public Person Manager { get; set; }
    }
}