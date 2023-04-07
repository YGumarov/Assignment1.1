static int FindMin(int[] nums, int n)
{
    if (n == 1)
    {
        return nums[0];
    }
    else
    {
        int min = FindMin(nums, n - 1);
        if (nums[n - 1] < min)
        {
            return nums[n - 1];
        }
        else
        {
            return min;
        }
    }
}


    int n = int.Parse(Console.ReadLine());
    int[] nums = new int[n];

    for (int i = 0; i < n; i++)
    {
        nums[i] = int.Parse(Console.ReadLine());
    }

    int min = FindMin(nums, n);
    Console.WriteLine(min);
