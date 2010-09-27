using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        /// <summary>
        /// The Flyweight pattern uses a single configurable object
        /// that is set on the fly and used in the code.
        /// </summary>
        public Program()
        {
            List<string> names = new List<string> { "Ralph", "Alice", "Sam" };
            List<int> ids = new List<int> { 1001, 1002, 1003 };
            List<int> scores = new List<int> { 45, 55, 65 };

            double total = 0;

            foreach( int score in scores )
            {
                total += score;
            }

            Student student = Student.Instance;
            student.AverageScore = total / scores.Count;
            
            for( int i = 0; i < scores.Count; i++ )
            {
                //The Student Object is configured on the fly
                student.Name = names[ i ];
                student.ID = ids[ i ];
                student.Score = scores[ i ];
                //The output is then read
                Console.WriteLine( "Student : {0}, Standing : {1}", student.Name, Math.Floor( student.Standing ) );
            }
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}
