
#pragma once
#include<stdio.h>
#include<stdlib.h>
#include<malloc.h>
#include<string.h>
#include<assert.h>
#define maxsize 10;
typedef int STDataType; 

// 支持动态增长的栈
typedef int STDataType;
typedef struct Stack 
{    STDataType* myarr;  
int _top;       // 栈顶  
int _capacity;  // 容量 
}Stack;

void StackInit(Stack* ps);
void StackCapacity(Stack* ps);
void Stackprint(Stack *ps);
void StackPush(Stack* ps, STDataType x); 
void StackPop(Stack* ps); 
STDataType StackTop(Stack* ps); 
int StackEmpty(Stack* ps);
int StackSize(Stack* ps);
void TestStack();