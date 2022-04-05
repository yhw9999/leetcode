public class Solution
{
	public int MyAtoi(string s)
	{
		var isNegative = false;
		var isPositive = false;
		var startedNumber = false;
		var result = 0d;

		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] >= 0x30 && s[i] <= 0x39)
			{
				startedNumber = true;

				result *= 10;
				result += s[i] - 0x30;
			}
			else
			{
				if (s[i] == ' ')
				{
					if (!startedNumber && (isNegative || isPositive))
					{
						return 0;
					}
					else if (startedNumber)
					{
						break;
					}

					continue;
				}
				if (s[i] == '-')
				{
					if (!startedNumber && (isNegative || isPositive))
					{
						return 0;
					}
					else if (!startedNumber)
					{
						isNegative = true;
					}
					else
					{
						break;
					}
				}
				else if (s[i] == '+')
				{
					if (!startedNumber && (isNegative || isPositive))
					{
						return 0;
					}
					else if (!startedNumber)
					{
						isPositive = true;
					}
					else
					{
						break;
					}
				}
				else
				{
					break;
				}
			}
		}

		if (isNegative)
		{
			return result < int.MinValue ? int.MinValue: -(int)result;
		}
		else
		{
			return result > int.MaxValue ? int.MaxValue : (int)result;
		}
	}
}