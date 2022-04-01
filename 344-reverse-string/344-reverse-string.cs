public class Solution
{
	public void ReverseString(char[] s)
	{
		var front = 0;
		var back = s.Length - 1; 
		while (front < back)
		{
			var tmp = s[front];
			s[front++] = s[back];
			s[back--] = tmp;
		}
	}
}