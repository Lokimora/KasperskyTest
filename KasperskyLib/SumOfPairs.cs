using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperskyLib
{
    public  class SumOfPairs
    {
        private int[] _numbers;
        private readonly int DefaultSize = 100;


        public SumOfPairs()
        {
            _numbers = Generate(DefaultSize).ToArray();

        } 

        public SumOfPairs(IEnumerable<int> testCaseCollection)
        {
            _numbers = testCaseCollection.ToArray();
        }

        //Maybe it would be better return some structure for perfomance  and to distinct 
        //duplicated but for 
        //clarity i decided just return list of string 
        public List<string> CalculatePairs(int x)
        {
            

            List<string> answers = new List<string>();

            for(int i = 0; i < _numbers.Count() - 1; i++)
            {
                if (_numbers[i] >= x)
                    continue;

                
                for(int j = i; j < _numbers.Count() - 1; j++)
                {
                    if(_numbers[i] + _numbers[j+1] == x)
                    {
                        answers.Add($"{_numbers[i]} : {_numbers[j + 1]}");
                    }
                }


            }

            return answers.Distinct().ToList();
        }


        private IEnumerable<int> Generate(int size = 1000)
        {


            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                yield return rnd.Next(1, 30) % 100;
            }

        }
    }

    
}
