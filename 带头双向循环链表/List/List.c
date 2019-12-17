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
void ListPopBack(ListNode* phead) // ˫������βɾ 
{
	ListNode * pre = phead->prev;
	ListNode *tail;
	tail = pre;
	pre = pre->prev;
	pre->next = phead;
	phead->prev = pre;
	free(tail);


}
void ListPrint(ListNode* phead) // ˫�������ӡ 
{
	printf("head-->");
	ListNode* list = phead->next;
	while (list!= phead)
	{
		printf("%d-->", list->date);
		list = list->next;
	}printf("head\n");
}
void ListPushFront(ListNode* phead, Datetype x) // ˫������ͷ��
{
	ListNode *newnode = BuyListNode(x);
	newnode->next = phead->next;
	phead->next->prev = newnode;
	phead->next = newnode;
	newnode->prev = phead;
}
void ListPopFront(ListNode* phead) // ˫������ͷɾ 
{
	ListNode *head;
	head = phead->next;
	phead->next = head->next;
	phead->next->prev = phead;
	free(head);
}
ListNode* ListFind(ListNode* phead, Datetype x) // ˫��������� 
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
	printf("���޴˽ڵ�\n");
	return NULL;
}
void ListInsert(ListNode* pos, Datetype x) // ˫��������pos��ǰ����в��� 
{
	
	ListNode *newnode = BuyListNode(x);
	ListNode *pre = pos->prev;
	newnode->next = pos;
	pos->prev = newnode;
	pre->next = newnode;
	newnode->prev =pre;
	
}
void ListErase(ListNode* pos)// ˫������ɾ��posλ�õĽڵ�
{
	ListNode *pre = pos->prev;
	pre->next = pos->next;
	pos->next = pre;
	free(pos);

}
void ListDestory(ListNode* phead)// ˫���������� 
{
	ListNode *pre = phead->next;
	phead->next = phead;
	phead->prev = phead;
	free(pre);
}