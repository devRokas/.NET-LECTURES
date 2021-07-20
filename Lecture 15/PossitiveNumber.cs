namespace Lecture_15
{
    public class PossitiveNumber : Number
    {
        public override int[] Generate()
        {
            for (var i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] = _random.Next(1, 1001);
            }

            return _numbers;
        }
    }
}