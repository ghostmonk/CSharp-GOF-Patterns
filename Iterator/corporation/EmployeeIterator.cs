using System.Collections.Generic;

namespace Iterator.corporation
{
    class EmployeeIterator : utils.Iterator
    {
        private List<Employee> employees;
        private int location;

        public EmployeeIterator( List<Employee> employees )
        {
            this.employees = employees;
            location = 0;
        }

        public bool HasNext()
        {
            return location < employees.Count && employees[ location ] != null;
        }

        public object Next()
        {
            return employees[ location++ ];
        }

        public void Remove()
        {
        }
    }
}
