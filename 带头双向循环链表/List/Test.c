#include"List.h"
int main()
{

	ListNode  *phead= CreatHead();
	ListPushBack(phead, 5);
	ListPushBack(phead, 6);
	ListPushBack(phead, 7);
	ListPushBack(phead, 8);
	ListPrint(phead);
	ListPopBack(phead);
	ListPrint(phead);
	ListPushFront(phead, 9);// Ë«ÏòÁ´±íÍ·²å
	ListPrint(phead);
	ListPopFront(phead);
	ListPrint(phead);
	ListFind(phead, 6);
	ListInsert(ListFind(phead,6), 99);
	ListPrint(phead);
	ListErase(ListFind(phead, 99));
	ListPrint(phead);
	ListDestory(phead);
    ListPrint(phead);
}