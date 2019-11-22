#include"SL.h"

void test1()
{

	SList*plist = NULL;
	
	SListPushBack(&plist, 2);
	SListPushBack(&plist, 3);
	SListPushBack(&plist, 4);
	
	//SListPrint(&plist);//打印
//	SListPushFront(&plist, 5);//头插
	//SListPrint(&plist);//打印
	SListPrint(plist);//打印
	SListPopBack(&plist);//尾删
	SListPrint(plist);//打印
	SListPopFront(&plist);//头删
	SListPrint(plist);//打印
	SListPopFront(&plist);//头删
	SListPrint(plist);//打印
	
}
void test2()
{

	SList*plist = NULL;

	SListPushBack(&plist, 2);
	SListPushBack(&plist, 3);
	SListPushBack(&plist, 4);

	
		//SListPushFront(&plist, 5);//头插

	SListPrint(plist);//打印
	//SListFind(&plist, 8);//查找链表值
	SListInsertAfter(&plist, 2, 10);//再pos的后面进行插入
	SListPrint(plist);//打印

}
int main()
{
	//test1();
	test2();
}