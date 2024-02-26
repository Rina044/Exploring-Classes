using System;

namespace JobTitle_lib
{
    public class JobTitle
    {
        /// <summary>
        /// Название должности
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Значение оклада
        /// </summary>
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Salary");
                }
            }
        }
    }
}
