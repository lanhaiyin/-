#include"SL.h"

void test1()
{

	SList*plist = NULL;
	
	SListPushBack(&plist, 2);
	SListPushBack(&plist, 3);
	SListPushBack(&plist, 4);
	
	//SListPrint(&plist);//��ӡ
//	SListPushFront(&plist, 5);//ͷ��
	//SListPrint(&plist);//��ӡ
	SListPrint(plist);//��ӡ
	SListPopBack(&plist);//βɾ
	SListPrint(plist);//��ӡ
	SListPopFront(&plist);//ͷɾ
	SListPrint(plist);//��ӡ
	SListPopFront(&plist);//ͷɾ
	SListPrint(plist);//��ӡ
	
}
void test2()
{

	SList*plist = NULL;

	SListPushBack(&plist, 2);
	SListPushBack(&plist, 3);
	SListPushBack(&plist, 4);

	
		//SListPushFront(&plist, 5);//ͷ��

	SListPrint(plist);//��ӡ
	//SListFind(&plist, 8);//��������ֵ
	SListInsertAfter(&plist, 2, 10);//��pos�ĺ�����в���
	SListPrint(plist);//��ӡ

}
int main()
{
	//test1();
	test2();
}