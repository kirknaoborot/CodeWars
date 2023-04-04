//Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

var res = Sort(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

Console.WriteLine(string.Join(", ", res));


static int[] Sort(int[] nums)
{
    var result  = new int[nums.Length];

    return nums.OrderBy(x => x == 0).ToArray();
}