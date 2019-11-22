#pragma once
#include<stdlib.h>
#include<string.h>
#include<assert.h>
#include<stdio.h>

typedef int SLTDataType;

typedef struct SList
{
	 SLTDataType _data;
	 struct SList* _next;
}SList;

SList* BuySListNode(SLTDataType x);
void SListPushFront(SList** pplist, SLTDataType x);
void SListPopFront(SList** pplist);//头删
void SListPushBack(SList** pplist, SLTDataType x);//尾插
void SListPopBack(SList** pplist);//尾删
SList* SListFind(SList** pplist, SLTDataType x);
// 在pos的后面进行插入
void SListInsertAfter(SList** pplist, SLTDataType pos, SLTDataType x);//再pos的前面进行插入
// 在pos的前面进行插入
void SListEraseAfter(SList* pos);
void SListRemove(SList** pplist, SLTDataType x);
void SListPrint(SList* plist);
void TestSList();