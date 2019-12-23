#include"heap.h"
#include<time.h>
void TestTopk()
{
	int n = 10000;
	int* a = (int*)malloc(sizeof(int)*n);
	srand(time(0));
	for (size_t i = 0; i < n; ++i)
	{
		a[i] = rand() % 1000000;
	}
	a[5] = 1000000 + 1;
	a[1231] = 1000000 + 2;
	a[531] = 1000000 + 3;
	a[5121] = 1000000 + 4;
	a[115] = 1000000 + 5;
	a[2335] = 1000000 + 6;
	a[9999] = 1000000 + 7;
	a[76] = 1000000 + 8;
	a[423] = 1000000 + 9;
	a[3144] = 1000000 + 10;

	/*a[5] = -1;
	a[1231] = -2;
	a[531] = -3;
	a[5121] = -4;
	a[115] = -5;
	a[2335] = -6;
	a[9999] = -7;
	a[76] = -8;
	a[423] = -9;
	a[3144] = -10;*/

	Heap hp;
	// 10个数据的小堆
	HeapInit(&hp, a, 10);
	for (size_t i = 10; i < n; ++i)  // N
	{
		if (a[i] > HeapTop(&hp)) // LogK
		{
			HeapPop(&hp);
			HeapPush(&hp, a[i]);
		}
	}

	HeapPrint(&hp);
}

// 升序 
void HeapSort(int* a, int n)
{
	// 建大堆
	for (int i = (n - 1 - 1) / 2; i >= 0; --i)
	{
		AdjustDown(a, n, i);
	}

		int end = n - 1;
	while (end > 0)
	{
		Swap(&a[0], &a[end]);
		AdjustDown(a, end, 0);
		--end;
	}
}


int main()
{
	Heap hp; HPDataType a[9] = { 1,4, 3, 5, 8, 6,0 };
	HeapInit(&hp, &a, 9);//o(n)
	HeapPrint(&hp);
	HeapPush(&hp, 10);//o(log n)
	HeapPrint(&hp);
	HeapPop(&hp);//出堆o(log n)
	HeapPrint(&hp);
	HeapPush(&hp, 12);
	HeapPrint(&hp);
	//找最大的前k个，建立k个数的小堆
	//找最小的前k个，建立k个数的大堆
	void TestTopk();
	void HeapSort(int* a, int n);
	return 0;
}