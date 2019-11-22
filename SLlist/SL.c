#include"SL.h"
SList *BuySListNode(SLTDataType x)//����һ���µĽ��
{
	SList * node = (SList*)malloc(sizeof(SList));//nodeָ��ָ�������ٵĿռ䣬�ռ�����_data��_next
	node->_data = x;
	node->_next = NULL;
	return node;
}
void SListPrint(SList* plist)//��ӡ
{
	SList * cur =plist;
	while (cur)
	{
		printf("%d->", cur->_data);
		cur = cur->_next;
	}
	printf("NULL\n");
}
void SListPushBack(SList** pplist, SLTDataType x)//β��
{
	SList* newnode = BuySListNode(x);
	
	if (*pplist == NULL)
	{
		*pplist = newnode;
	}
	else
	{
		SList* tail = *pplist;
		while(tail->_next)
		{
			
			tail = tail->_next;
		}
		tail->_next = newnode;
	}
}
void SListPopBack(SList** pplist)//βɾ
{
	SList*plist = *pplist;
	SList*tail = *pplist;
	SList*pre = *pplist;
	if (plist == NULL || (plist->_next == NULL))
	{
		free(plist);
		*pplist = NULL;
	}
	else
	{
		while (tail->_next)
		{
			pre = tail;
			tail = tail->_next;
		}
		pre->_next = NULL;
		free(tail);
		tail = NULL;
	}
}
void SListPopFront(SList** pplist)//ͷɾ
{
	SList*plist = *pplist;
	SList*next = *pplist;
	
	if (plist == NULL )
	{
		*pplist = NULL;
	}
	else if (plist->_next == NULL)
	{
		free(plist);
	*pplist=NULL;
	}
	else
	{
		next = plist->_next;
		free(plist);
		*pplist = next;
	}

}
void SListPushFront(SList** pplist, SLTDataType x)//ͷ��
{
	SList* newnode =BuySListNode(x);
	
	if (*pplist == NULL)
	{
		*pplist = newnode;
	}
	else
	{
		newnode->_next =*pplist;
		*pplist = newnode;
	}
}
SList* SListFind(SList** pplist, SLTDataType x)//��������ֵ
{
	assert(pplist);
	SList* tail = *pplist;
	while (tail)
	{
		if (tail->_data == x)
		{
			printf("��\n");
			return;
		}
		else
			tail = tail->_next;
	}printf("û��\n");
}
void SListInsertAfter(SList** pplist, SLTDataType pos, SLTDataType x)//��pos�ĺ�����в���
{
	SList* newnode = BuySListNode(x);

	SList* tail = *pplist;
	SList* pre = tail;
	if (* pplist== NULL)
	{
		tail = newnode;
		*pplist = tail;
	}
	else
	{

		while (--pos)
		{
			if (tail == NULL)
			{
				printf("������Ч\n");
				return;
			}
				
			tail = tail->_next;
		}
		SList* p= tail;
		newnode->_next = tail->_next;
		p->_next = newnode;
		*pplist = pre;
		
	}
}
