using System;

namespace Lecture_15
{
    public abstract class Number
    {
        protected readonly Random _random;
        protected int[] _numbers;

        protected Number()
        {
            _random = new Random();
            _numbers = new int[_random.Next(20, 201)];
        }
        
        public abstract int[] Generate();

        public int GetSum()
        {
            var sum = 0;

            foreach (var number in _numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}