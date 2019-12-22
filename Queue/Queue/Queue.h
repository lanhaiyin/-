#pragma once
#include<stdio.h>
#include<stdlib.h>
#include<malloc.h>
#include<assert.h>

typedef int QUDataType;

typedef struct QueueNode 
{ 
	struct QueueNode* _next; 
    QUDataType _data;
}QueueNode;

typedef struct Queue 
{
	QueueNode* _front; // ��ͷ   
	QueueNode* _rear;  // ��β
}Queue;


void QueueInit(Queue* pq); //��ʼ������
void QueueDestory(Queue* pq);//��ն���
void QueuePrint(Queue *pq);
QueueNode* BuyQueueNode(QUDataType x); //�����½ڵ�
void QueuePush(Queue* pq, QUDataType x);//�����
void QueuePop(Queue* pq); //������
QUDataType QueueFront(Queue* pq);//��ͷ��ֵ
QUDataType QueueBack(Queue* pq); //��β��ֵ
int QueueEmpty(Queue* pq); //�ж϶����Ƿ�Ϊ��
int QueueSize(Queue* pq);//���еĴ�С
