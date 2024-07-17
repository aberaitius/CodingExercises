using System;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1
            int[] nums1_case1 = {1, 2, 3, 0, 0, 0};
            int m_case1 = 3;
            int[] nums2_case1 = {2, 5, 6};
            int n_case1 = 3;
            Merge(nums1_case1, m_case1, nums2_case1, n_case1);
            Console.WriteLine(string.Join(", ", nums1_case1)); // Expected output: 1, 2, 2, 3, 5, 6

            // Test Case 2
            int[] nums1_case2 = {1};
            int m_case2 = 1;
            int[] nums2_case2 = { };
            int n_case2 = 0;
          //  Merge(nums1_case2, m_case2, nums2_case2, n_case2);
            //Console.WriteLine(string.Join(", ", nums1_case2)); // Expected output: 1

            // Test Case 3
            int[] nums1_case3 = {0};
            int m_case3 = 0;
            int[] nums2_case3 = {1};
            int n_case3 = 1;
           // Merge(nums1_case3, m_case3, nums2_case3, n_case3);
            //Console.WriteLine(string.Join(", ", nums1_case3)); // Expected output: 1

            // Add more test cases as needed
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
             //foreach element in num 2 
        //go through num1 if 0 then replace 0 and break

        foreach (var item in nums2){

                for (int i = 0; i < nums1.Count(); i++)
                {
                    if( nums1[i] == 0 ){
                        Console.WriteLine( "nums1" + nums1[i] + "| item :" + item );
                        nums1[i] = item;
                        break;
                    }
                }
        }
        //orderby does not merge the array correctly
        Array.Sort(nums1);
    }
}
}    


/*

or we can use 2 pointer method
  public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Pointer for nums1
            int j = n - 1; // Pointer for nums2
            int k = m + n - 1; // Pointer for the end of merged array in nums1

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // If there are remaining elements in nums2
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
*/
