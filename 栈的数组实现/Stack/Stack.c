#include"Stack.h"
void StackInit(Stack* ps)//����������
{
	assert(ps);
	ps->_capacity = maxsize;
	ps->_top = 0;
	ps->myarr = (STDataType*)malloc(sizeof(STDataType)*ps->_capacity);
	if (ps->myarr == NULL)
		return NULL;
}
void StackCapacity(Stack* ps)//����
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

void StackPush(Stack* ps, STDataType x)//��ջ
{
	assert(ps);
	StackCapacity(ps);
	ps->myarr[ps->_top] = x;
	ps->_top++;
}
void Stackprint(Stack *ps)//��ӡջ
{
	assert(ps);
	Stack *p = ps;
	for (int i = 0; i < ps->_top; i++)
	{
		printf("%d  ", ps->myarr[i]);

	}printf("\n");
}
void StackPop(Stack* ps)//��ջ
{
	assert(ps);
	if (ps->_top == 0)
	{
		printf("ջΪ��\n");
		return NULL;
	}
	
	ps->_top--;
}
int StackEmpty(Stack* ps)//���ջ
{
	assert(ps);
	ps->_capacity = 0;
	ps->_top = 0;
	free(ps->myarr);
	if (ps->_top == 0)
		printf("ջΪ��");
}
int StackSize(Stack* ps)//���ջ�Ĵ�С
{
	assert(ps); 
	
	 printf("ջ�ĳ���Ϊ%d\n",ps->_top);
}
STDataType StackTop(Stack* ps)
{
	assert(ps);
	if (ps->_top == 0)
	{
		printf("ջΪ��\n");
		return NULL;
	}
	printf("ջ��������%d\n", ps->myarr[ps->_top-1]);
	
}