#pragma once
#include<stdio.h>
#include<stdlib.h>
#include<assert.h>
#include<malloc.h>
typedef int Datetype;
typedef struct ListNode
{
	Datetype date;
	struct ListNode * prev;
	struct ListNode * next;
}ListNode;


ListNode* CreatHead();//����ͷ�ڵ�
ListNode* BuyListNode(Datetype x);
void ListPrint(ListNode* head); // ˫�������ӡ 
void ListPushBack(ListNode* phead, Datetype x);// ˫������β�� 
void ListPopBack(ListNode* phead); // ˫������βɾ 

void ListPushFront(ListNode* phead,Datetype x); // ˫������ͷ��
void ListPopFront(ListNode* phead); // ˫������ͷɾ 
void ListDestory(ListNode* phaed); // ˫���������� 

void ListPrint(ListNode* head); // ˫�������ӡ 

ListNode* ListFind(ListNode* phead, Datetype x); // ˫��������� 
void ListInsert(ListNode* pos,Datetype x); // ˫��������pos��ǰ����в��� 
void ListErase(ListNode* pos);// ˫������ɾ��posλ�õĽڵ�