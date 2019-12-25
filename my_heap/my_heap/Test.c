#include"Heap.h"
void sort(int*brr, int n)//堆排序
{
	//建立一个大堆
	for (int i = (n - 2) / 2; i >= 0; --i)
	{
		AdjustDown(brr, n,i);
	}
	int end =n - 1;
	while (end)//每次将堆顶的值放在最后，再继续向下调整，继续互换
	{
		swap(&brr[0], &brr[end]);
		AdjustDown(brr, end, 0);

		end--;
	}

	HeapPrint(&brr);
}
int main()
{
	Heap hp;   HPDataType a[10] = { 11,1, 2, 3, 4, 5, 6, 7, 8, 9 };
    HeapCreat(&hp,&a, 10); //堆的初始化
	HeapPrint(&hp);
	HeapPush(&hp,30);//入堆
	HeapPrint(&hp);
	HeapPush(&hp, 15);//入堆
	HeapPrint(&hp);
	HeapPop(&hp);//出堆
	HeapPrint(&hp);
	//HeapSize(&hp); //堆的大小
   // HeapTop(&hp); //
  //  HeapEmpty(&hp);//判断堆是否为空
	//HeapDestory(&hp); //堆的清空*/
	int brr[5] = { 5, 8, 3, 1, 4 };
     sort(&brr, 5);
}