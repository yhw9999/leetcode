public class Solution
{
    Dictionary<int, List<string>> map = new Dictionary<int, List<string>>()
    {
        {2, new List<string>(){"a","b","c"} },
        {3, new List<string>(){"d","e","f"} },
        {4, new List<string>(){"g","h","i"} },
        {5, new List<string>(){"j","k","l"} },
        {6, new List<string>(){"m","n","o"} },
        {7, new List<string>(){"p","q","r", "s" } },
        {8, new List<string>(){"t","u","v"} },
        {9, new List<string>(){"w","x","y","z"} }
    };

    public IList<string> LetterCombinations(string digits)
    {
        var queue = new Queue<string>();

        for (int i = 0; i < digits.Length; i++)
        {
            var number = int.Parse(digits[i].ToString());

            var cadidate = queue.ToList();
            queue.Clear();

            foreach (var item in map[number])
            {
                if (cadidate.Count == 0)
                {
                    queue.Enqueue(item);
                }
                else
                {
                    foreach (var prefix in cadidate)
                    {
                        queue.Enqueue(prefix + item);
                    }
                }
            }
        }

        return queue.ToList();
    }
}