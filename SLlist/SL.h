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
void SListPopFront(SList** pplist);//ͷɾ
void SListPushBack(SList** pplist, SLTDataType x);//β��
void SListPopBack(SList** pplist);//βɾ
SList* SListFind(SList** pplist, SLTDataType x);
// ��pos�ĺ�����в���
void SListInsertAfter(SList** pplist, SLTDataType pos, SLTDataType x);//��pos��ǰ����в���
// ��pos��ǰ����в���
void SListEraseAfter(SList* pos);
void SListRemove(SList** pplist, SLTDataType x);
void SListPrint(SList* plist);
void TestSList();