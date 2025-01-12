namespace ArrayManagement
{
    public class IntArray : ICalc2, IOutput2
    {
        private int[] _elements;

        public IntArray(int[] elements)
        {
            if (elements == null || elements.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");
            _elements = elements;
        }

        public int CountDistinct()
        {
            return _elements.Distinct().Count();  
        }

        public int EqualToValue(int valueToCompare)
        {
            return _elements.Count(x => x == valueToCompare); 
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