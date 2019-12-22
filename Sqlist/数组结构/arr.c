#include"arr.h"
void sqinitseqlist(pseqlist pseq,size_t capicity)//初始化顺序表
{
	assert(pseq);
		pseq->capicity = maxsize;
		pseq->size = 0;
	pseq->myarr= (datetype*)malloc(sizeof(datetype)*capicity);
	assert(pseq->myarr);
	if (pseq->myarr ==NULL)
		printf("创建失败");
	
}
void sqpushback(pseqlist pseq, datetype  date)//尾插法插入元素
{
	assert(pseq);
	sqcheckcapicity( pseq);
	pseq->myarr[pseq->size] = date;
	pseq->size++;
}
 void sqcheckcapicity(pseqlist pseq)//检查容量并增容
{
	assert(pseq);
	if (pseq->size == pseq->capicity)
	{
		if (pseq->capicity == 0)
		{
			pseq->capicity = 2;
		}
		datetype * temp=(datetype *)realloc(pseq->myarr, pseq->capicity * 2 * sizeof(datetype));
		pseq->myarr = temp;
		pseq->capicity *= 2;
	}
	return pseq;
}
void sqemptymyarr(pseqlist pseq)//判空
{
	assert(pseq);
	if (pseq->size == 0)
		printf("顺序表为空");
}

void sqprint(pseqlist pseq)//打印顺序表
{
	assert(pseq);
	for (int i = 0; i<(pseq-> size); i++)
	{
		printf("%d ", pseq->myarr[i]);

	}printf("\n");
}
void sqpopback(pseqlist pseq, datetype  date)//尾删
{
	assert(pseq);
	sqemptymyarr(pseq);
	pseq->size--;
	return pseq;
}
void sqpushfront(pseqlist pseq, datetype  date)//头插
{
	assert(pseq);
	sqcheckcapicity(pseq);
	for (int i = (pseq->size-1); i >=0; i--)//从后往前挪
	{
		pseq->myarr[i+1] = pseq->myarr[i];
	}
	pseq->myarr[0] = date;
	pseq->size++;
}

void sqpopfront(pseqlist pseq)//头删
{
	assert(pseq);
	sqemptymyarr(pseq);//从前往后挪
	for (int i = 0; i < (pseq->size); i++)
	{
		pseq->myarr[i] = pseq->myarr[i + 1];
	}
	pseq->size--;
}
void sqpushpos(pseqlist pseq, int pos,datetype date)//在pos位插入
{
	assert(pseq);
	sqcheckcapicity(pseq);

	if (pos<1 || pos>pseq->size)
		printf("插入位置不合法\n");
	else
	{
		for (int i = (pseq->size); i>(pos - 1); i--)
		{
			pseq->myarr[i] = pseq->myarr[i - 1];
		}
		pseq->myarr[pos - 1] = date;
		pseq->size++;

	}
	
}
void sqpoppos(pseqlist pseq, int pos)//在pos位删除
{
	assert(pseq);
	sqemptymyarr(pseq);
	if (pos<1 || pos>pseq->size)
	{
		printf("删除位置不合法\n");
	}
	else
	{
		for (int i = (pos - 1); i<(pseq->size); i++)
		{
			pseq->myarr[i] = pseq->myarr[i + 1];
		}
		pseq->size--;
	}
}
void sqfinddate(pseqlist pseq, datetype x)
{
	assert(pseq);
	int flag = 0;
	for (int i = 0; i < (pseq->size); i++)
	{
		if (pseq->myarr[i] == x)
		{
			printf("%d ", i); flag = 1;//可以找到x元素的所有下标
		}
			
	}printf("\n");
	if (flag == 0)
		printf("没有找到此元素\n");
	
}
void sqdestory(pseqlist pseq)//清空所创建的空间
{
	assert(pseq);
	pseq->size = 0;
	pseq->capicity = 0;
	free(pseq->myarr);
	sqemptymyarr(pseq);
	
}
void sqmodify(pseqlist pseq, int pos, datetype x)//修改pos位的值
{
	assert(pseq);
	if (pos<1 || pos>pseq->size)
		printf("修改位置不合法\n");
	else
	{
		pseq->myarr[pos-1] = x;
	}
	
}
void sqremove(pseqlist pseq, datetype x)//删除元素
{
	assert(pseq);
	sqemptymyarr(pseq);
	int count = 0; int flag = 0;
	for (int i = 0; i < (pseq->size); i++)
	{
		if (pseq->myarr[i] == x)
			flag = 1;


	}
	if (flag == 0)
	{
		printf("没找到\n");
		return;
	}
	for (int i = 0; i < (pseq->size); i++)
	{
		
		if ((pseq->myarr[i]) == x)
		{
		
			for (count; count< (pseq->size);count++)
			{
				pseq->myarr[count] = pseq->myarr[count+1];
			}
			
		}
		count++;
	}
	pseq->size--;
}
void sqremoveall(pseqlist pseq, datetype x)//删除所有x元素   //垃圾算法，赶紧优化0
{
	assert(pseq);
	sqemptymyarr(pseq);
	int temp = 0; int flag = 0;
	for (int i = 0; i < (pseq->size); i++)
	{
		if (pseq->myarr[i] == x)
			flag = 1;


	}
	if (flag == 0)
	{
		printf("没找到\n");
		return;
	}
	for (int i = 0; i < (pseq->size); i++)
	{
		int j = temp;
		if ((pseq->myarr[i]) == x)
		{

			for (; j< (pseq->size);j++)
			{
				pseq->myarr[j] = pseq->myarr[j+ 1];
			}
			i--; temp--;
			pseq->size--;
		}
		temp++;//让temp和i保持一致

	}
}

void sqbubblesort(pseqlist pseq)//冒泡排序
{
	sqemptymyarr(pseq);
	for (int i = 0; i < (pseq->size-1); i++)
	{
		for (int j = 0; j < (pseq->size - i - 1); j++)
		{
			if (pseq->myarr[j]>pseq->myarr[j + 1])
			{
				int temp = pseq->myarr[j + 1];
				pseq->myarr[j + 1] = pseq->myarr[j];
				pseq->myarr[j] = temp;
			}
		}
	}
}
void sqremoveall2(pseqlist pseq, datetype x)
{
	int src = 0; int dst = 0; int flag = 0;
	for (int i = 0; i < (pseq->size); i++)
	{
		if (pseq->myarr[i] == x)
			flag = 1;
	}
	if (flag == 0)
	{
		printf("没找到\n");
		return;
	}
		
	while (src < (pseq->size))
	{
		if (pseq->myarr[src] == x)
		{
			src++; 
		}
		else
		{
			dst = src;
			printf("%d ",pseq->myarr[dst]);//只是打印出不为x元素下标所对应的元素，
										//	如果将src的值给dst就可以使用循环将dst打印出来
			src++;
		}
	}
	printf("\n");
}
void sqbinaryfind(pseqlist pseq,datetype x)//二分查找
{
	sqemptymyarr(pseq);
	int left = 0; int right = pseq->size ; int mid = (left + right) / 2;
	while (left <= right)
	{
		if (pseq->myarr[mid] > x)
		{
			right = mid - 1;
			mid = (left + right) / 2;
		}
		if (pseq->myarr[mid] <x)
		{
			left = mid + 1;
			mid = (left + right) / 2;
		}
		if (pseq->myarr[mid] == x)
		{
			printf("找到了，下标为%d\n",mid);
			return;
		}
	}
	printf("没有找到此元素\n");

}