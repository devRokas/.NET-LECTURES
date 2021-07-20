namespace Lecture_15
{
    public class EvenNumber : Number
    {
        public override int[] Generate()
        {
            for (var i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = RandomNumberEven(1, 1001);
            }

            return _numbers;
        }
        
        private int RandomNumberEven(int min, int max)
        {
            var ans = _random.Next(min, max);
            if (ans % 2 == 0) return ans;
            
            if (ans + 1 <= max)
            {
                return ans + 1;
            }
                
            if (ans - 1 >= min)
            {
                return ans - 1;
            }
            
            return 0;
        }
    }
}