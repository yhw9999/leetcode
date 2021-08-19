public class Solution {
		public string IntToRoman(int num)
		{
			var dict = new Dictionary<int, char>();
			dict.Add(1, 'I');
			dict.Add(5, 'V');
			dict.Add(10, 'X');
			dict.Add(50, 'L');
			dict.Add(100, 'C');
			dict.Add(500, 'D');
			dict.Add(1000, 'M');

			var sb = new StringBuilder();

			for (int i = 1000; i > 0; i /= 10)
			{
				var value = num / i;

				if (value != 0)
				{
					if (value >= 1 && value < 4)
					{
						for (int j = 0; j < value; j++)
						{
							sb.Append(dict[i]);
						}
					}
					else if (value == 4) {
						sb.Append(dict[i]);
						sb.Append(dict[i * 10 / 2]);
					}
					else if (value == 5)
					{
						sb.Append(dict[i * 5]);
					}
					else if(value >= 6 && value < 9)
					{
						sb.Append(dict[i * 5]);
						for (int j = 0; j < value - 5; j++)
						{
							sb.Append(dict[i]);
						}
					}
					else
					{
						sb.Append(dict[i]);
						sb.Append(dict[i * 10]);
					}

					num = num % i;
				}
			}


			return sb.ToString();
		}
}