#include"Queue.h"
int main()
{
	Queue pq;
	QueueInit(&pq);
	
	QueuePush(&pq,2);//�����
	QueuePush(&pq,3);
	QueuePush(&pq,4);
	printf("%d   ", pq._front->_data);
	printf("%d   ", pq._rear->_data);
	QueuePrint(&pq);
	QueuePop(&pq); //������
	QueuePrint(&pq);
    QueueFront(&pq);//��ͷ��ֵ
	QueueBack(&pq); //��β��ֵ
	QueueEmpty(&pq); //�ж϶����Ƿ�Ϊ��
    QueueSize(&pq);//���еĴ�С
	QueueDestory(&pq);//��ն���
	QueuePrint(&pq);

}