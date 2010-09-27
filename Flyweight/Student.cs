namespace Flyweight
{
    /// <summary>
    /// Using a static instance getter to ensure a single instance in a 
    /// threaded environment.
    /// </summary>
    public class Student
    {
        private static Student instance = new Student();

        private Student() {}

        public string Name{ get; set; }

        public int ID { get; set; }
        
        public int Score { get; set; }

        public double AverageScore { set; private get; }

        public double Standing
        {
            get
            {
                return ( ( (double)Score ) / AverageScore - 1.0 ) * 100.0;   
            }
        }

        public static Student Instance
        {
            get { return instance; }
        }
    }
}
