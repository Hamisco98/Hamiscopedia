# 🧩 PS #0001 - Indexes of Subarray Sum

### 🧠 Problem Statement
Given an array `arr[]` containing only non-negative integers,  
find a **continuous subarray** (a contiguous sequence of elements)  
whose sum equals a specified value `target`.

You must return the **1-based indices** of the leftmost and rightmost elements of this subarray.  
If no such subarray exists, return `[-1]`.

You need to find the **first** subarray whose sum equals the target.

---

### 📘 Examples

| Input | Output | Explanation |
|--------|--------|-------------|
| `arr = [1, 2, 3, 7, 5], target = 12` | `[2, 4]` | The sum of elements from 2nd to 4th position is 12. |
| `arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], target = 15` | `[1, 5]` | The sum of elements from 1st to 5th position is 15. |
| `arr = [5, 3, 4], target = 2` | `[-1]` | There is no subarray with sum 2. |

---

### ⚙️ Constraints
```
1 <= arr.length <= 10⁶  
0 <= arr[i] <= 10³  
0 <= target <= 10⁹
```

---

### ⏱️ Expected Complexities
| Type | Complexity |
|------|-------------|
| Time | **O(n)** |
| Space | **O(1)** |

---

### 💡 Approach
Since all numbers are **non-negative**, we can efficiently solve this using the **Sliding Window** technique.

#### Idea:
- Maintain a running window `[left, right]` and a variable `currentSum`.
- Expand the window by moving `right` and adding `arr[right]` to `currentSum`.
- If `currentSum` exceeds the target, shrink the window from the left.
- If `currentSum` equals the target, return `[left+1, right+1]` (1-based indices).

---

### 👨‍💻 C# Solution #1
```csharp
public static int[] FindSubarray(int[] arr, int target)
{
    long sum = 0;
    int left = 0;

    for (int right = 0; right < arr.Length; right++)
    {
        sum += arr[right];

        while (left <= right && sum > target)
            sum -= arr[left++];

        if (sum == target)
            return new List<int> { left + 1, right + 1 };
    }

    return new List<int> { -1 };
}
```

### 👨‍💻 C# Solution #2
```csharp
public static int[] FindSubarray(int[] arr, int target)
{
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
```

---

### 🧩 Summary
| Category | Value |
|-----------|--------|
| Concept | Sliding Window |
| Language | C# |
| Difficulty | 🟡 Medium |
| Time Complexity | O(n) |
| Space Complexity | O(1) |
| Created by | Hemisco |
