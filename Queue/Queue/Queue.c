#include"Queue.h"
void QueueInit(Queue* pq)//初始化队列
{
	assert(pq);
	pq->_front = NULL;
	pq->_rear = NULL;
}
void QueueDestory(Queue* pq) //清空队列
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
QueueNode* BuyQueueNode(QUDataType x) //创建新节点
{
	QueueNode * newnode = (QueueNode *)malloc(sizeof(QueueNode));
	newnode->_data = x;
	newnode->_next = NULL;
	return newnode;
}
void QueuePush(Queue* pq, QUDataType x)//入队列
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
void QueuePop(Queue* pq) //出队列
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
QUDataType QueueFront(Queue* pq)//队头的值
{
	if (pq->_front != NULL)
	{
		printf("%d\n", pq->_front->_data);
		return pq->_front->_data;
	}
	return NULL;
}
QUDataType QueueBack(Queue* pq)//队尾的值
{
	if (pq->_rear != NULL)
	{
		printf("%d\n", pq->_rear->_data);
		return pq->_rear->_data;
	}return NULL;
}
int QueueEmpty(Queue* pq) //判断队列是否为空
{
	if (pq->_rear->_data == NULL)
		printf("队为空\n");
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
int QueueSize(Queue* pq)//队列的大小
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
