#include "List.h"
ListNode* CreatHead()
{
	
	ListNode * phead = (ListNode *)malloc(sizeof(ListNode));
	if (phead != NULL)
	{
		phead->next = phead;
		phead->prev = phead;
		phead->date = NULL;
	}
	return phead;
}
ListNode* BuyListNode(Datetype x)
{
	ListNode * newnode = (ListNode *)malloc(sizeof(ListNode));
	newnode->date = x;
	newnode->next = NULL;
	newnode->prev = NULL;
	return newnode;
}
void ListPushBack(ListNode* phead, Datetype x)
{
	assert(phead);

	ListNode * newnode=BuyListNode(x);
	ListNode * pre=phead->prev;
	pre->next = newnode;
	newnode->prev = pre;
	phead ->prev = newnode;
	newnode->next = phead;
}
void ListPopBack(ListNode* phead) // 双向链表尾删 
{
	ListNode * pre = phead->prev;
	ListNode *tail;
	tail = pre;
	pre = pre->prev;
	pre->next = phead;
	phead->prev = pre;
	free(tail);


}
void ListPrint(ListNode* phead) // 双向链表打印 
{
	printf("head-->");
	ListNode* list = phead->next;
	while (list!= phead)
	{
		printf("%d-->", list->date);
		list = list->next;
	}printf("head\n");
}
void ListPushFront(ListNode* phead, Datetype x) // 双向链表头插
{
	ListNode *newnode = BuyListNode(x);
	newnode->next = phead->next;
	phead->next->prev = newnode;
	phead->next = newnode;
	newnode->prev = phead;
}
void ListPopFront(ListNode* phead) // 双向链表头删 
{
	ListNode *head;
	head = phead->next;
	phead->next = head->next;
	phead->next->prev = phead;
	free(head);
}
ListNode* ListFind(ListNode* phead, Datetype x) // 双向链表查找 
{
	ListNode* cur = phead->next;
	while (phead!= cur)
	{
		if (cur->date == x)
		{
			return cur;
		}
		else
			cur = cur->next;
		
	}
	printf("查无此节点\n");
	return NULL;
}
void ListInsert(ListNode* pos, Datetype x) // 双向链表在pos的前面进行插入 
{
	
	ListNode *newnode = BuyListNode(x);
	ListNode *pre = pos->prev;
	newnode->next = pos;
	pos->prev = newnode;
	pre->next = newnode;
	newnode->prev =pre;
	
}
void ListErase(ListNode* pos)// 双向链表删除pos位置的节点
{
	ListNode *pre = pos->prev;
	pre->next = pos->next;
	pos->next = pre;
	free(pos);

}
void ListDestory(ListNode* phead)// 双向链表销毁 
{
	ListNode *pre = phead->next;
	phead->next = phead;
	phead->prev = phead;
	free(pre);
}