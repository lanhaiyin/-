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


ListNode* CreatHead();//创建头节点
ListNode* BuyListNode(Datetype x);
void ListPrint(ListNode* head); // 双向链表打印 
void ListPushBack(ListNode* phead, Datetype x);// 双向链表尾插 
void ListPopBack(ListNode* phead); // 双向链表尾删 

void ListPushFront(ListNode* phead,Datetype x); // 双向链表头插
void ListPopFront(ListNode* phead); // 双向链表头删 
void ListDestory(ListNode* phaed); // 双向链表销毁 

void ListPrint(ListNode* head); // 双向链表打印 

ListNode* ListFind(ListNode* phead, Datetype x); // 双向链表查找 
void ListInsert(ListNode* pos,Datetype x); // 双向链表在pos的前面进行插入 
void ListErase(ListNode* pos);// 双向链表删除pos位置的节点