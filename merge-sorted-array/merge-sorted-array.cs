public class Solution {
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			var currentIndex = nums1.Length - 1;
			m--;
			n--;

			while (m >= 0 && n >= 0)
			{
				if (nums1[m] > nums2[n])
				{
					nums1[currentIndex--] = nums1[m--];
				}
				else
				{
					nums1[currentIndex--] = nums2[n--];
				}
			}

			if (m >= 0)
			{
				while(currentIndex > -1)
				{
					nums1[currentIndex--] = nums1[m--];
				}

				return;
			}

			if(n >= 0)
			{
				while (currentIndex > -1)
				{
					nums1[currentIndex--] = nums2[n--];
				}

				return;
			}
		}
}