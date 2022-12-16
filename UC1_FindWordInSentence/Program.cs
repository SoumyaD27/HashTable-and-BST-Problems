using System;
namespace UC1_FindWordInSentence
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<int, string> hash = new MyMapNode<int, string>();
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            hash.GetFrequency();
        }
    }
}