namespace NavigatingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            var b = new Book();

            b.UpdatePrice(22, 150M);

        }

        private void AnotherDemo()
        {
            var b2 = new Book();
            b2.UpdatePrice(543, 12.50M);
        }

    }
}
