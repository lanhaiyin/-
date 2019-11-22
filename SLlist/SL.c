#include"SL.h"
SList *BuySListNode(SLTDataType x)//创建一个新的结点
{
	SList * node = (SList*)malloc(sizeof(SList));//node指针指向所开辟的空间，空间里有_data和_next
	node->_data = x;
	node->_next = NULL;
	return node;
}
void SListPrint(SList* plist)//打印
{
	SList * cur =plist;
	while (cur)
	{
		printf("%d->", cur->_data);
		cur = cur->_next;
	}
	printf("NULL\n");
}
void SListPushBack(SList** pplist, SLTDataType x)//尾插
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
void SListPopBack(SList** pplist)//尾删
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
void SListPopFront(SList** pplist)//头删
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
void SListPushFront(SList** pplist, SLTDataType x)//头插
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
SList* SListFind(SList** pplist, SLTDataType x)//查找链表值
{
	assert(pplist);
	SList* tail = *pplist;
	while (tail)
	{
		if (tail->_data == x)
		{
			printf("有\n");
			return;
		}
		else
			tail = tail->_next;
	}printf("没有\n");
}
void SListInsertAfter(SList** pplist, SLTDataType pos, SLTDataType x)//再pos的后面进行插入
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
				printf("插入无效\n");
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
