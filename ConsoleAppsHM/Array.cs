namespace ArrayManagement
{
    public class IntArray : ICalc, IOutput2
    {
        private int[] _elements;

        public IntArray(int[] elements)
        {
            if (elements == null || elements.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            _elements = elements;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var element in _elements)
            {
                if (element < valueToCompare)
                    count++;
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var element in _elements)
            {
                if (element > valueToCompare)
                    count++;
            }
            return count;
        }

        public void ShowEven()
        {
            var evenNumbers = _elements.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers: ");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

        public void ShowOdd()
        {
            var oddNumbers = _elements.Where(n => n % 2 != 0);
            Console.WriteLine("Odd numbers: ");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}