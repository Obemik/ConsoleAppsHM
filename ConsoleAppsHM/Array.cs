namespace ArrayManagement
{
    public class MyArray : ICalc
    {
        private int[] _elements;

        public MyArray(int[] elements)
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
    }
}