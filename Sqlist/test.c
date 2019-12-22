#include"arr.h"
#define _CRT_SECURE_NO_WARNINGS 1
int main()
{
	seqlist  s;
	
	sqinitseqlist(&s);
	sqpushback(&s,  1);//尾插
	sqpushback(&s,  2);//尾插
	sqpushback(&s, 3);//尾插
	sqpushback(&s, 4);//尾插
	sqprint(&s);
	sqpopback(&s);//尾删
	sqprint(&s);
	sqpushfront(&s, 7);//头插
	sqpushfront(&s, 8);
	sqprint(&s);
	sqpopfront(&s);//头删
	sqprint(&s);


	sqpushpos(&s, 2, 9);//在pos位置插入
	sqprint(&s);
	sqpoppos(&s, 1);//在pos位删除
    sqprint(&s);
	sqpushpos(&s, 2, 7);//在pos位置插入
	sqprint(&s);
	sqpushpos(&s, 4, 7);//在pos位置插入
	sqprint(&s);
	sqfinddate(&s, 2);
	sqfinddate(&s, 3);
	sqpushpos(&s, 5, 7);
	sqmodify(&s, 3, 55);//修改pos位的值
	
	sqprint(&s);
	sqremove(&s, 7);//删除某个元素
	sqremoveall(&s,7);//删除所有x元素
	sqprint(&s);
	//sqremoveall2(&s, 7);
	sqpushback(&s, 1);//尾插
	sqpushback(&s, 2);//尾插
	sqpushback(&s, 3);//尾插
	sqpushback(&s, 4);//尾插
	sqbubblesort(&s);//排序
	sqprint(&s);
	sqbinaryfind(&s, 4);
	//sqprint(&s);
	//sqdestory(&s);//清空所创建的空间
	//sqprint(&s);
}
