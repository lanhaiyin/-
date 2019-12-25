#include"Heap.h"
//�������
void HeapCreat(Heap* hp, HPDataType* a, int n) //�ѵĳ�ʼ��
{
	hp->_capacity = hp->_size = n;
	hp->_a = (HPDataType*)malloc(sizeof(HPDataType)*n);
	memcpy(hp->_a,a,sizeof(HPDataType)*n);//��a�����е����ݿ�������
	for (int i = (n - 2) / 2; i >= 0; --i)
	{
		//���µ���
		AdjustDown(hp->_a, hp->_size,i);
		
	}
}
void HeapDestory(Heap* hp) //�ѵ����
{
	free(hp->_a);
	hp->_capacity = 0;
	hp->_size = 0;
	HeapEmpty(hp);
}
void HeapPush(Heap* hp, HPDataType x)//���
{
	if (hp->_size == hp->_capacity)
	{
		hp->_capacity = hp->_capacity*2;
		hp->_a = realloc(hp->_a, sizeof(HPDataType)*hp->_capacity);
	}
	hp->_a[hp->_size++] = x;
	//���ϵ���
	AdjustUp(hp->_a, hp->_size, hp->_size - 1);


}
Heap *swap(HPDataType *x, HPDataType *y)
{
	HPDataType c = *y;
	*y= *x;
	*x = c;

}
void HeapPop(Heap* hp)//����
{
	assert(hp);
	swap(&hp->_a[0],&hp->_a[hp->_size - 1]);
	hp->_size--;
	AdjustDown(hp->_a, hp->_size, 0);//���µ���
}
HPDataType HeapTop(Heap* hp) //�Ѷ�
{
	if (hp->_size == 0)
	{
		return NULL;
	}
	else
	{
		printf("�Ѷ�Ϊ%d\n", hp->_a[0]);
	}
	return hp->_a[0];
}
int HeapSize(Heap* hp)//�ѵĴ�С
{
	assert(hp);
	printf("�ѵĴ�С%d\n", hp->_size);
	return hp->_size;
}
HPDataType HeapEmpty(Heap* hp)//�ж϶��Ƿ�Ϊ��
{
	if (hp->_size == 0)
	{
		printf("��Ϊ��\n");
		return 1;
	}
	
	else
	{
		printf("�Ѳ�Ϊ��\n");
		return 0;
	}
}
void  AdjustUp(HPDataType *a, int n, int child)//���ϵ���
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
void  AdjustDown(HPDataType *a, int n, int root)//���µ���
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
void HeapPrint(Heap* hp)//��ӡ
{
	for (int i = 0; i < hp->_size; i++)
	{
		printf("%d  ", hp->_a[i]);
	}printf("\n");
}
