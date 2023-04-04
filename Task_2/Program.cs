// See https://aka.ms/new-console-template for more information

var res = Sort(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

Console.WriteLine(string.Join(", ", res));


static int[] Sort(int[] nums)
{
    var result  = new int[nums.Length];

    var zeroNums = nums.Where(_ => _ == 0).ToArray();

    int j = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            result[j] = nums[i];

            j++;
        }
    }

    return result.Concat(zeroNums).ToArray();
}