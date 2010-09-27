using System.Collections.Generic;

namespace Iterator.corporation
{
    class EmployeeCollection
    {
        private List<Employee> employees;

        public EmployeeCollection()
        {
            employees = new List<Employee>( 100 );
        }

        public void Add( Employee employee )
        {
            employees.Add( employee );
        }

        public EmployeeIterator Iterator()
        {
            return new EmployeeIterator( employees );
        }
    }
}
