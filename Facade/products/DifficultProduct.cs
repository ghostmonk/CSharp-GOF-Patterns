namespace Facade.products
{
    public class DifficultProduct
    {
        private char[] nameChars = new char[ 7 ];

        public void SetNameChar1( char c )
        {
            nameChars[ 0 ] = c;
        }

        public void SetNameChar2( char c )
        {
            nameChars[ 1 ] = c;
        }

        public void SetNameChar3( char c )
        {
            nameChars[ 2 ] = c;
        }

        public void SetNameChar4( char c )
        {
            nameChars[ 3 ] = c;
        }

        public void SetNameChar5( char c )
        {
            nameChars[ 4 ] = c;
        }

        public void SetNameChar6( char c )
        {
            nameChars[ 5 ] = c;
        }

        public void SetNameChar7( char c )
        {
            nameChars[ 6 ] = c;
        }

        public string GetName()
        {
            return new string( nameChars );
        }
    }
}
