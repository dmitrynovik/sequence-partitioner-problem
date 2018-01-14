using System.Collections.Generic;
using System.Linq;
using CodeTests;

namespace SequencePartitioner
{
    public static class SequencePartitioner<T>
    {
        /// <summary>
        /// 
        /// Given a sequence, partition it into the minimal sub-sequences so that no subsequence contains an item included in other sub-sequences;
        /// 
        /// Output the list of sub-sequences lengths.
        /// 
        /// Examples: 
        /// ['a', 'b', 'c'] => [1, 1, 1] ('a' 'b' and 'c' a unique so that each susequence has 1 item)
        /// ['a', 'b', 'c', 'a'] => [4] (cannot be split because either split will include 'a')
        /// ['a', 'b', 'a', 'b', 'c', 'b', 'a', 'c', 'a', 'd', 'e', 'f', 'e', 'g', 'd', 'e', 'h', 'i', 'j', 'h', 'k', 'l', 'i', 'j'] => [9, 7, 8]
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public static ICollection<int> Partition<T>(ICollection<T> inputList)
        {
            var result = new List<int>();
            if (inputList == null)
                return result;

            int previous = 0;
            for (int i = 1; i <= inputList.Count; i++)
            {
                var head = inputList.Take(i).ToHashSet();
                var tail = inputList.Skip(i).ToHashSet();
                if (!head.Any(c => tail.Contains(c)))
                {
                    result.Add(i - previous);
                    previous = i;
                }
            }
            return result;
        }
    }
}
