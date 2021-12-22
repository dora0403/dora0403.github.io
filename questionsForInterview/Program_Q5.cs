public class Solution {
    public void Question5(int[] nums) {
        int tmp;
        
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i+1; j < nums.Length; j++) {
                if (nums[j] < nums[i]) {
                    tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }
        Console.WriteLine(nums);
    }
}