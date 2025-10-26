int[] arr = new int[] { 5, 3, 4 };
int target = 2;

var result_1 = SubarraySumSolution_1(arr, target);
var result_2 = SubarraySumSolution_2(arr, target);

Console.WriteLine("Result By Applying Solution #1: [" + string.Join(", ", result_1) + "]");
Console.WriteLine("Result By Applying Solution #2: [" + string.Join(", ", result_2) + "]");


static List<int> SubarraySumSolution_1(int[] arr, int target)
{
    /*--------------- Solution 1 ---------------*/

    int startPosition = 1,
        endPosition = 1,
        currentSum = 0,
        attempt = 0;

    for (int index = 0; index < arr.Length && attempt < arr.Length;)
    {
        currentSum += arr[index];

        if (currentSum == target)
            return new List<int> { startPosition, endPosition };

        else if (currentSum > target)
        {
            currentSum = 0;
            attempt++;
            index = attempt;
            startPosition = index + 1;
            endPosition = index + 1;
        }

        else
        {
            endPosition++;
            index++;
        }
    }

    return new List<int> { -1 };
}

static List<int> SubarraySumSolution_2(int[] arr, int target)
{
    /*--------------- Solution 2 ---------------*/

    long sum = 0;
    int left = 0;

    for (int right = 0; right < arr.Length; right++)
    {
        sum += arr[right];

        while (sum > target)
            sum -= arr[left++];

        if (sum == target)
            return new List<int> { left + 1, right + 1 };
    }
    return new List<int> { -1 };
}