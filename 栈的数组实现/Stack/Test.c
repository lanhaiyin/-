#include"Stack.h"
int main()
{
	Stack ps;
	StackInit(&ps);//����������
	StackPush(&ps, 1);
	StackPush(&ps, 2);
	StackPush(&ps, 5);
	Stackprint(&ps);
	StackPop(&ps);
	
	Stackprint(&ps);
	StackPush(&ps, 9);
	Stackprint(&ps);
	StackSize(&ps);
	StackTop(&ps);
//	Stackprint(&ps);
	//StackEmpty(&ps);

}
