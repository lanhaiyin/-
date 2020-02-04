给你一个仅由数字 6 和 9 组成的正整数 num。

你最多只能翻转一位数字，将 6 变成 9，或者把 9 变成 6 。

请返回你可以得到的最大数字。

示例 1：

输入：num = 9669
输出：9969
解释：
改变第一位数字可以得到 6669 。
改变第二位数字可以得到 9969 。
改变第三位数字可以得到 9699 。
改变第四位数字可以得到 9666 。
其中最大的数字是 9969 。
示例 2：

输入：num = 9996
输出：9999
解释：将最后一位从 6 变到 9，其结果 9999 是最大的数。
示例 3：

输入：num = 9999
输出：9999
解释：无需改变就已经是最大的数字了。
提示：

1 <= num <= 10^4 num 每一位上的数字都是 6 或者 9 。

来源：力扣（LeetCode） 链接：https://leetcode-cn.com/problems/maximum-69-number 著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。




int S_len(int  num)
{
	int sum = 0;
	while (num)
	{
		num /= 10;
		sum++;
	}
	return sum;
}

int maximum69Number (int num)
{
      int len=S_len( num);
     int *arr=(int*)malloc(sizeof(int)*len);
    //将num数的每一位存放到数组里，这里是倒着存放的
    int i=len-1;
    while(num>0)
    {
         arr[i--]=num%10;
         num/=10;
    }
    //数字的长度为i
   i=0;
    while(i<len)
    {
        if(arr[i]==6)
        {
            arr[i]=9;
            break;
        }
        i++;
    }
    len=len-1;int sum=0;int t=1;
    //计算数组里的数
   while(len>=0)
   {
       sum+=arr[len]*t;
       t*=10;
       --len;
   }
   printf("%d",sum);
   return sum;
}
