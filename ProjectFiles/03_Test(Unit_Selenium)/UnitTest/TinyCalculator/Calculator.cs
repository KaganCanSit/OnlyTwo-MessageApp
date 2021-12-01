using System;

namespace TinyCalculator
{
    public class Calculator
    {

        Operator[] _operators = new Operator[] 
        {
            new Operator('+', (left,right) => {return left + right; }),
            new Operator('-', (left,right) => {return left - right; }),
            new Operator('*', (left,right) => {return left * right; }),
            new Operator('/', (left,right) => {return left / right; })
        };

        class Operator
        {
            public char Symbol;
            public Func<int, int, int> Function;
            public Operator(char symbol, Func<int,int,int> function)
            {
                Symbol = symbol;
                Function = function;
            }
        }

        public int Calculate(string input)
        {
            foreach(var o in _operators)
            {
                if (input.Contains(o.Symbol))
                {
                    string[] parts = input.Split(new char[] { o.Symbol }, StringSplitOptions.RemoveEmptyEntries);
                    int left = Convert.ToInt32(parts[0]);
                    int right = Convert.ToInt32(parts[1]);

                    return o.Function(left, right);
                }
            }

            throw new InvalidOperationException();
        }
    }
}