#include"Queue.h"
int main()
{
	Queue pq;
	QueueInit(&pq);
	
	QueuePush(&pq,2);//入队列
	QueuePush(&pq,3);
	QueuePush(&pq,4);
	printf("%d   ", pq._front->_data);
	printf("%d   ", pq._rear->_data);
	QueuePrint(&pq);
	QueuePop(&pq); //出队列
	QueuePrint(&pq);
    QueueFront(&pq);//队头的值
	QueueBack(&pq); //队尾的值
	QueueEmpty(&pq); //判断队列是否为空
    QueueSize(&pq);//队列的大小
	QueueDestory(&pq);//清空队列
	QueuePrint(&pq);

}