#include"Queue.h"
void QueueInit(Queue* pq)//��ʼ������
{
	assert(pq);
	pq->_front = NULL;
	pq->_rear = NULL;
}
void QueueDestory(Queue* pq) //��ն���
{
	assert(pq);
	QueueNode *cur = pq->_front;
	while (cur!= NULL)
	{
		QueueNode *next = cur->_next;
		free(cur);
		cur = next;
	}
	pq->_front = pq->_rear = NULL;
}
QueueNode* BuyQueueNode(QUDataType x) //�����½ڵ�
{
	QueueNode * newnode = (QueueNode *)malloc(sizeof(QueueNode));
	newnode->_data = x;
	newnode->_next = NULL;
	return newnode;
}
void QueuePush(Queue* pq, QUDataType x)//�����
{
	assert(pq);
	QueueNode *newnode = BuyQueueNode(x);
	if (pq->_front == NULL)
	{
		pq->_rear=pq->_front = newnode;
	}
	else
	{
		pq->_rear->_next = newnode;
		pq->_rear = newnode;
	}
	

}
void QueuePop(Queue* pq) //������
{
	assert(pq);
	
		
	QueueNode *pfront = pq->_front->_next;
	free(pq->_front);
	pq->_front = pfront;
	if (pq->_front == NULL)
	{
		 pq->_front = NULL;
	}

}
QUDataType QueueFront(Queue* pq)//��ͷ��ֵ
{
	if (pq->_front != NULL)
	{
		printf("%d\n", pq->_front->_data);
		return pq->_front->_data;
	}
	return NULL;
}
QUDataType QueueBack(Queue* pq)//��β��ֵ
{
	if (pq->_rear != NULL)
	{
		printf("%d\n", pq->_rear->_data);
		return pq->_rear->_data;
	}return NULL;
}
int QueueEmpty(Queue* pq) //�ж϶����Ƿ�Ϊ��
{
	if (pq->_rear->_data == NULL)
		printf("��Ϊ��\n");
	return 0;
}
void QueuePrint(Queue *pq)
{
	assert(pq);
	QueueNode *cur = pq->_front;
	if (pq->_front == NULL)
	{
		printf("zhankong\n");
		return 0;
	}
	while (cur)
	{
		printf("%d-->", cur->_data);
		cur = cur->_next;
	}printf("\n");
}
int QueueSize(Queue* pq)//���еĴ�С
{
	assert(pq);
	int size = 0;
	QueueNode *cur = pq->_front;
	while (cur)
	{
		size++;
		cur = cur->_next;
	}
	printf("%d\n", size);
	return size;
}
