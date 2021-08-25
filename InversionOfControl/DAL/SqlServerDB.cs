using System;

namespace InversionOfControl
{
    public class SqlServerDB : IDataAccessLayer
    {
        public void Add(Patient patient)
        {
            Console.WriteLine("Patient has been added to SqlServer");
        }
    }
}