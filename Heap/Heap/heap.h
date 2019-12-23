#pragma once
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<assert.h>
#include<malloc.h>
#include<assert.h>
#define maxsize 10;
typedef int HPDataType;
typedef struct Heap 
{ 
	HPDataType* _a;
    size_t _size;   
    size_t _capacity; 
}Heap;

void HeapInit(Heap* hp, HPDataType* a, int n); //�ѵĳ�ʼ��
void HeapDestory(Heap* hp); //�ѵ����
void HeapPush(Heap* hp, HPDataType x);//���
void HeapPop(Heap* hp); //����
HPDataType HeapTop(Heap* hp); //
Heap *swap(HPDataType *a, HPDataType* b);//����
int HeapSize(Heap* hp); //�ѵĴ�С
int HeapEmpty(Heap* hp);//�ж϶��Ƿ�Ϊ��
void  AdjustUp(HPDataType *a, int n, int child);//���ϵ���
void  AdjustDown(HPDataType *a, int n, int root);//���µ���
// ������ void HeapSort(int* a, int n);
void HeapPrint(Heap* hp);//��ӡ
void TestHeap();