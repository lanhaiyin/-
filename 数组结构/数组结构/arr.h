#pragma once
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<assert.h>
#define maxsize 1
typedef int datetype;
typedef struct seqlist
{
	datetype *myarr;
	size_t size;
	
	size_t capicity;
}seqlist,*pseqlist;
void initseqlist(pseqlist pseq);//初始化顺序表
void sqpushback(pseqlist pseq, datetype date);//尾插法插入元素
void sqpopback(pseqlist pseq);//尾删
void sqpushfront(pseqlist pseq, datetype date);//头插
void sqpopfront(pseqlist pseq);//头删
void sqprint(pseqlist pseq);//打印顺序表
void sqcheckcapicity(pseqlist pseq);//增容
void sqemptymyarr(pseqlist pseq);//判空
void sqpushpos(pseqlist pseq,int pos, datetype date);//在pos位插入
void sqpoppos(pseqlist pseq, int pos);//在pos位删除
void sqfinddate(pseqlist pseq, datetype x);//寻找x元素的下标
void sqdestory(pseqlist pseq);//清空所创建的空间
void sqmodify(pseqlist pseq, int pos, datetype x);//修改pos位的值
void sqremove(pseqlist pseq, datetype x);//删除元素
void sqbubblesort(pseqlist pseq);//冒泡排序
void sqremoveall(pseqlist pseq, datetype x);//删除所有x元素
void sqremoveall2(pseqlist pseq, datetype x);
void sqbinaryfind(pseqlist pseq, datetype x);//二分查找