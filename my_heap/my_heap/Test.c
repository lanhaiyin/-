#include"Heap.h"
void sort(int*brr, int n)//������
{
	//����һ�����
	for (int i = (n - 2) / 2; i >= 0; --i)
	{
		AdjustDown(brr, n,i);
	}
	int end =n - 1;
	while (end)//ÿ�ν��Ѷ���ֵ��������ټ������µ�������������
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
    HeapCreat(&hp,&a, 10); //�ѵĳ�ʼ��
	HeapPrint(&hp);
	HeapPush(&hp,30);//���
	HeapPrint(&hp);
	HeapPush(&hp, 15);//���
	HeapPrint(&hp);
	HeapPop(&hp);//����
	HeapPrint(&hp);
	//HeapSize(&hp); //�ѵĴ�С
   // HeapTop(&hp); //
  //  HeapEmpty(&hp);//�ж϶��Ƿ�Ϊ��
	//HeapDestory(&hp); //�ѵ����*/
	int brr[5] = { 5, 8, 3, 1, 4 };
     sort(&brr, 5);
}