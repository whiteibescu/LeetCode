#include <iostream>
#include <limits.h>


using namespace std;

class Solution {
public :
	int reverse(int x)
	{
        int result = 0;
        int prev = 0;
        int cur = 0;
        while (x != 0)
        {
            cur = x % 10;
            x /= 10;

            if (result > INT_MAX / 10 || result < INT_MIN / 10) {
                return 0;
            }

            result = result * 10 + cur;

            if ((result - cur) / 10 != prev)
            {
                return 0;
            }

            prev = result;
        }
        return result;

	}

    void Start()
    {
        int num;
        cout << "Input Integer" << endl;
        cin >> num;
        reverse(num);
    }
};

int main()
{
    Solution* s;
    s = new Solution();
    s->Start();
}