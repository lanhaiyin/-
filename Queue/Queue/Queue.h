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
	QueueNode* _front; // 队头   
	QueueNode* _rear;  // 队尾
}Queue;


void QueueInit(Queue* pq); //初始化队列
void QueueDestory(Queue* pq);//清空队列
void QueuePrint(Queue *pq);
QueueNode* BuyQueueNode(QUDataType x); //创建新节点
void QueuePush(Queue* pq, QUDataType x);//入队列
void QueuePop(Queue* pq); //出队列
QUDataType QueueFront(Queue* pq);//队头的值
QUDataType QueueBack(Queue* pq); //队尾的值
int QueueEmpty(Queue* pq); //判断队列是否为空
int QueueSize(Queue* pq);//队列的大小
