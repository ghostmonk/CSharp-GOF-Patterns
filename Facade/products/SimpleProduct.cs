namespace Facade.products
{
    class SimpleProduct : ISimpleProduct
    {
        private DifficultProduct product;

        public SimpleProduct()
        {
            product = new DifficultProduct();
        }

        public void SetName( string name )
        {
            char[] chars = name.ToCharArray();

            if( chars.Length > 0 ) product.SetNameChar1( chars[ 0 ] );
            if( chars.Length > 1 ) product.SetNameChar2( chars[ 1 ] );
            if( chars.Length > 2 ) product.SetNameChar3( chars[ 2 ] );
            if( chars.Length > 3 ) product.SetNameChar4( chars[ 3 ] );
            if( chars.Length > 4 ) product.SetNameChar5( chars[ 4 ] );
            if( chars.Length > 5 ) product.SetNameChar6( chars[ 5 ] );
            if( chars.Length > 6 ) product.SetNameChar7( chars[ 6 ] );
        }

        public string GetName()
        {
            return product.GetName();
        }
    }
}
