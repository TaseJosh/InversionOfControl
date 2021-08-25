using System;

namespace InversionOfControl
{
    public class MySqlDB : IDataAccessLayer
    {
        public void Add(Patient patient)
        {
            Console.WriteLine("Patient has been added to MySQL");
        }
    }
}