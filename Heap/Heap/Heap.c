#include"heap.h"
void HeapInit(Heap* hp, HPDataType* a, int n)//堆的初始化
{

	assert(hp && a);
	hp->_a= (HPDataType*)malloc(sizeof(HPDataType)*n);
	hp->_size = hp->_capacity = n;
	memcpy(hp->_a, a, sizeof(HPDataType)*n);//把a的数据拷过来
	//建堆
	for (int i = (n- 2) / 2; i >= 0; --i)
	{
		AdjustDown(hp->_a, hp->_size, i);
	}

}

Heap *swap(HPDataType *a, HPDataType* b)
{
	HPDataType c = *b;
	*b = *a;
	*a = c;
}
void  AdjustUp(HPDataType *a, int n, int child)
{
	HPDataType parent = (child - 1) / 2;
	while (child>0)
	{
		
		if (a[parent] > a[child])
		{
			swap(&a[parent], &a[child]);
			child = parent;
			parent = (child - 1) / 2;
		}
		else
			break;
	}
}

void  AdjustDown( HPDataType *a,int n,int root)
{
	HPDataType parent = root;
	HPDataType child = 2*parent+1;
	while (child<n)
	{
		if (a[child] >a[child + 1]&&(child+1)<n)

			child++;
		if (a[child] < a[parent])
		{
			swap(&a[parent], &a[child]);
			parent = child;
			child = 2 * parent+1;
		}
		else break;

	}
	

}

void HeapPush(Heap* hp,  HPDataType x)//入堆
{
	if (hp->_size = hp->_capacity)
	{
		hp->_capacity *= 2;
		hp->_a = realloc(hp->_a,sizeof(HPDataType)*hp->_capacity);
	}
		
	hp->_a[hp->_size] = x;
	hp->_size++;
	
	AdjustUp(hp->_a,hp->_size,hp->_size-1);
	
}
void HeapPrint(Heap* hp)
{
	for (int i = 0; i < hp->_size; i++)
	{
		printf("%d", hp->_a[i]);
	}printf("\n");
}
void HeapPop(Heap* hp)//出堆
{
	swap(&hp->_a[0], &hp->_a[hp->_size - 1]);
	hp->_size--;
	AdjustDown(hp->_a, hp->_size , 0);
}
void HeapDestory(Heap* hp) //堆的清空
{
	free(hp->_a);
	hp->_a = NULL;
	hp->_capacity = hp->_size = 0;
}
HPDataType HeapTop(Heap* hp) //
{
	return hp->_a[0];
}
int HeapSize(Heap* hp) //堆的大小
{
	return hp->_size;
}
int HeapEmpty(Heap* hp)//判断堆是否为空
{
	return hp->_size == 0 ? 1 : 0;
}
