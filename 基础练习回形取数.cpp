#include <iostream>
//#include <cstdio>
//#include <string.h>
//#include <algorithm>
#include <iomanip>
using namespace std;

void print(int arr[200][200],int m,int n)
{
   int k=0;int sum=0;
   int i=0;int j=0;
   while(sum<m*n)//a用来标记是否已经用过
   {
       for(i=k;i<m-k;i++)//打印左边
       {
             if(sum==m*n)break;
           cout<<arr[i][k]<<" ";
           sum++;

       }
       for(j=k+1;j<n-k-1;j++)//打印下面
       {
             if(sum==m*n)break;
           cout<<arr[m-k-1][j]<<" ";
         sum++;

       }
       for(i=m-k-1;i>=k;i--)//打印右边
       {
            if(sum==m*n)break;
           cout<<arr[i][n-k-1]<<" ";
          sum++;

       }
       for(j=n-k-2;j>=k+1;j--)//打印上面
       {
            if(sum==m*n)break;
           cout<<arr[k][j]<<" ";
         sum++;

       }
       k++;
   }

}

int main()
{
    //m行n列
    int m=0;
    int n=0;
    cin>>m>>n;
    int arr[200][200];
    for(int i=0;i<m;i++)
    {
         for(int j=0;j<n;j++)
         {
             cin>>arr[i][j];
         }
    }
   /* for(int i=0;i<m;i++)
    {
         for(int j=0;j<n;j++)
         {
             cout<<arr[i][j];
         }
         cout<<endl;
    }*/
    print(arr,m,n);
}
