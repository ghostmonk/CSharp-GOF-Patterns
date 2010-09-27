using System;
using Composite.elements;

namespace Composite
{
    class Program
    {
        public Program()
        {
            Branch reptiles = new Branch( "Reptiles" );
            reptiles.Add( new Leaf( "snake", "Reptile" ) );
            reptiles.Add( new Leaf( "iguana", "Reptile" ) );
            reptiles.Add( new Leaf( "geko", "Reptile" ) );
            
            Branch birds = new Branch( "Birds" );
            birds.Add( new Leaf( "Parrot", "Bird" ) );
            birds.Add( new Leaf( "Chickadee", "Bird" ) );
            birds.Add( new Leaf( "Finch", "Bird" ) );

            Branch mammals = new Branch( "Mammals" );
            mammals.Add( new Leaf( "Tiger", "Mammal" ) );
            mammals.Add( new Leaf( "Elephant", "Mammal" ) );
            mammals.Add( new Leaf( "Bear", "Mammal" ) );

            Branch animals = new Branch( "Animals" );
            animals.Add( reptiles );
            animals.Add( birds );
            animals.Add( mammals );

            animals.Print();
        }

        static void Main( string[] args )
        {
            new Program();
            Console.ReadLine();
        }
    }
}