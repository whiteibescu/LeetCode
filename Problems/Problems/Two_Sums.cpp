#include <iostream>
#include <algorithm>
#include <vector>
/*/
Given an array of integers numsand an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.


Example 1:

Input: nums = [2, 7, 11, 15], target = 9
Output : [0, 1]
Output : Because nums[0] + nums[1] == 9, we return[0, 1].
Example 2 :

	Input : nums = [3, 2, 4], target = 6
	Output : [1, 2]
	Example 3 :

	Input : nums = [3, 3], target = 6
	Output : [0, 1]


	Constraints :

	2 <= nums.length <= 103
	- 109 <= nums[i] <= 109
	- 109 <= target <= 109
	Only one valid answer exists.
*/
using namespace std;

class Solution {
public:
	vector<int> twoSum(vector<int>& nums, int target) {
		unsigned int inputNumSize = nums.size();
		vector<int> userAnswer;
		for (int i = 0; i < inputNumSize; i++)
		{
			for (int j = i + 1; j < inputNumSize; j++)
			{
				if (nums[i] + nums[j] == target)
				{
					userAnswer.push_back(i);
					userAnswer.push_back(j);
					break;
				}
			}
		}
		return userAnswer;

	}
};


int main()
{

}
