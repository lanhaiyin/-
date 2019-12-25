#include"Heap.h"
//建立大堆
void HeapCreat(Heap* hp, HPDataType* a, int n) //堆的初始化
{
	hp->_capacity = hp->_size = n;
	hp->_a = (HPDataType*)malloc(sizeof(HPDataType)*n);
	memcpy(hp->_a,a,sizeof(HPDataType)*n);//把a数组中的数据拷贝过来
	for (int i = (n - 2) / 2; i >= 0; --i)
	{
		//向下调整
		AdjustDown(hp->_a, hp->_size,i);
		
	}
}
void HeapDestory(Heap* hp) //堆的清空
{
	free(hp->_a);
	hp->_capacity = 0;
	hp->_size = 0;
	HeapEmpty(hp);
}
void HeapPush(Heap* hp, HPDataType x)//入堆
{
	if (hp->_size == hp->_capacity)
	{
		hp->_capacity = hp->_capacity*2;
		hp->_a = realloc(hp->_a, sizeof(HPDataType)*hp->_capacity);
	}
	hp->_a[hp->_size++] = x;
	//向上调整
	AdjustUp(hp->_a, hp->_size, hp->_size - 1);


}
Heap *swap(HPDataType *x, HPDataType *y)
{
	HPDataType c = *y;
	*y= *x;
	*x = c;

}
void HeapPop(Heap* hp)//出堆
{
	assert(hp);
	swap(&hp->_a[0],&hp->_a[hp->_size - 1]);
	hp->_size--;
	AdjustDown(hp->_a, hp->_size, 0);//向下调整
}
HPDataType HeapTop(Heap* hp) //堆顶
{
	if (hp->_size == 0)
	{
		return NULL;
	}
	else
	{
		printf("堆顶为%d\n", hp->_a[0]);
	}
	return hp->_a[0];
}
int HeapSize(Heap* hp)//堆的大小
{
	assert(hp);
	printf("堆的大小%d\n", hp->_size);
	return hp->_size;
}
HPDataType HeapEmpty(Heap* hp)//判断堆是否为空
{
	if (hp->_size == 0)
	{
		printf("堆为空\n");
		return 1;
	}
	
	else
	{
		printf("堆不为空\n");
		return 0;
	}
}
void  AdjustUp(HPDataType *a, int n, int child)//向上调整
{
	int parent = (child - 1) / 2;
	while (child>0)
	{
		if (a[child] > a[parent])
		{
			swap(&a[child], &a[parent]);
			child = parent;
			parent = (child - 1) / 2;
		}
		else
			break;
	}
}
void  AdjustDown(HPDataType *a, int n, int root)//向下调整
{
	int child = root * 2 + 1;
	while (child<n)
	{
		if (a[child] < a[child + 1]&&(child+1)<n)
		{
			child++;
		}
		if (a[child]>a[root])
		{
			swap(&a[child], &a[root]);
			root = child;
			child = 2 * root + 1;
		}
		else
			break;  
	}
}
void HeapPrint(Heap* hp)//打印
{
	for (int i = 0; i < hp->_size; i++)
	{
		printf("%d  ", hp->_a[i]);
	}printf("\n");
}
