#include"Stack.h"
void StackInit(Stack* ps)//创建空数组
{
	assert(ps);
	ps->_capacity = maxsize;
	ps->_top = 0;
	ps->myarr = (STDataType*)malloc(sizeof(STDataType)*ps->_capacity);
	if (ps->myarr == NULL)
		return NULL;
}
void StackCapacity(Stack* ps)//扩容
{
	assert(ps);
	if (ps->_top == ps->_capacity)
	{
		if (ps->myarr == 0)
			ps->_capacity = 2;
		ps->myarr= (STDataType *)realloc(ps->myarr, ps->_capacity*sizeof(STDataType)* 2);
		ps->_capacity = ps->_capacity * 2;

	}
}

void StackPush(Stack* ps, STDataType x)//入栈
{
	assert(ps);
	StackCapacity(ps);
	ps->myarr[ps->_top] = x;
	ps->_top++;
}
void Stackprint(Stack *ps)//打印栈
{
	assert(ps);
	Stack *p = ps;
	for (int i = 0; i < ps->_top; i++)
	{
		printf("%d  ", ps->myarr[i]);

	}printf("\n");
}
void StackPop(Stack* ps)//出栈
{
	assert(ps);
	if (ps->_top == 0)
	{
		printf("栈为空\n");
		return NULL;
	}
	
	ps->_top--;
}
int StackEmpty(Stack* ps)//清空栈
{
	assert(ps);
	ps->_capacity = 0;
	ps->_top = 0;
	free(ps->myarr);
	if (ps->_top == 0)
		printf("栈为空");
}
int StackSize(Stack* ps)//输出栈的大小
{
	assert(ps); 
	
	 printf("栈的长度为%d\n",ps->_top);
}
STDataType StackTop(Stack* ps)
{
	assert(ps);
	if (ps->_top == 0)
	{
		printf("栈为空\n");
		return NULL;
	}
	printf("栈顶的内容%d\n", ps->myarr[ps->_top-1]);
	
}