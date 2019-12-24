#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

//进程控制块(PCB)
struct PCB
{
	char name;
	float arrivetime;
	float servetime;
	float finishtime;
	float roundtime;
	float daiquantime;
};

struct PCB a[100];
struct PCB b[100];
char *jczt[] = { "运行", "就绪" };//*表示没有字符串的大小限制

//打印统计信息
void tjxx(int n)
{
	float averoundtime = 0.0f;
	float avedaiquantime = 0.0f;
	printf("按任意键查看统计信息");
	getchar(); getchar();
	printf("\n\n进程名称\t到达时间\t服务时间\t完成时间\t周转时间\t带权周转时间");
	for (int j = 0; j < n; j++)
	{
		printf("\n %c\t\t%4.f\t\t%4.f\t\t%4.f\t\t%4.f\t\t %.2f\n", a[j].name, a[j].arrivetime, a[j].servetime, a[j].finishtime, a[j].roundtime, a[j].daiquantime);
		averoundtime += a[j].roundtime;
		avedaiquantime += a[j].daiquantime;
	}

	printf("\n平均周转时间:%.2f", averoundtime / n);
	printf("\n\n平均带权周转时间:%.2f\n", avedaiquantime / n);
}

void xlxfw(int n)
{
	int time = 0; //定义当前时刻
	int processnum = 0; //定义当前进程指向
	struct PCB t; //定义一个空的结构体节点
	int processztsy = 0; //定义进程状态索引

	while (1)
	{
		printf("当前时刻：%2d\n", time);

		//排序
		for (int i = 1; i < n; i++)
		{
			for (int j = 0; j < n - i; j++)
			{
				if (a[j].arrivetime > a[j + 1].arrivetime)//先到先运行
				{
					t = a[j];
					a[j] = a[j + 1];
					a[j + 1] = t;
				}
				if (a[j].arrivetime == a[j + 1].arrivetime)//进程同时到
				{
					if (a[j].servetime > a[j + 1].servetime)//比较服务时间,将运行时间短的放在优先级高的位置
					{
						t = a[j];
						a[j] = a[j + 1];
						a[j + 1] = t;
					}
				}
			}
		}


		for (int k = 0; k< n; k++)
		{

			if (time == a[k].arrivetime && a[k].arrivetime != 0)
			{

				if (k >= 1 && time >= a[k - 1].finishtime || k == 0)
				{
					processztsy = 0;
				}
				else
				{
					processztsy = 1;
				}
				printf("\t\t进程 %c 到达\t进程状态\n", a[k].name);
				printf("\n\t\t\t\t  %s\n\n\n", jczt[processztsy]);



				if (processnum >= 1)
				{
					a[k].finishtime = a[k - 1].finishtime + a[k].servetime;
					a[k].roundtime = a[k].finishtime - a[k].arrivetime;
					a[k].daiquantime = a[k].roundtime / a[k].servetime;
				}
				if (processnum == 0)
				{
					a[k].finishtime = a[k].arrivetime + a[k].servetime;
					a[k].roundtime = a[k].finishtime - a[k].arrivetime;
					a[k].daiquantime = a[k].roundtime / a[k].servetime;
					printf("\t\t\t进程  %c  开始\n\n\n\n", a[processnum].name);
					processnum++;
				}
			}

			if (time == a[k].finishtime && a[k].finishtime != 0)
			{
				printf("\t\t\t进程  %c  完成\n\n\n\n", a[k].name);
			}

			if ((k >= 1 && time >= a[k].arrivetime && time == a[k - 1].finishtime && a[k].arrivetime != 0))
			{
				printf("\t\t\t进程  %c  开始\n\n\n\n", a[k].name);
			}
		}


		if (time > a[n - 1].finishtime && a[n - 1].finishtime != 0)
		{
			printf("\t\t\t所有进程已进程已加载完毕！ \n\n\n\n");
			break;
		}
		time++;
		Sleep(1000);
	}
	tjxx(n);
}

void djcyx(int n)
{
	struct PCB t;
	int time = 0;//定义当前时刻
	int jcnum = 0;
	int jcztsy = 0;
	int ztgb = 0;

	//排序
	for (int i = 1; i < n; i++)
	{
		for (int j = 0; j < n - i; j++)
		{
			if (a[j].arrivetime > a[j + 1].arrivetime)//先到达的优先级高
			{
				t = a[j];
				a[j] = a[j + 1];
				a[j + 1] = t;
			}
		}
	}

	while (1)
	{
		printf("当前时刻：%d\n", time);


		//遍历数组，注意同时达到的进程，所以采用for循环遍历
		for (int k = 0; k< n; k++)
		{
			//是否有进程的到达时间等于当前时刻
			if (time == a[k].arrivetime && a[k].arrivetime != 0)
			{
				//判断到达进程因该处于什么状态
				if (k >= 1 && time >= a[k - 1].finishtime || k == 0)
				{
					jcztsy = 0;
				}
				else
				{
					jcztsy = 1;
				}
				printf("\t\t进程 %c 到达\t进程状态\n\n\n\n", a[k].name);
			}
		}

		if (jcnum == 0)
		{
			//遍历数组
			for (int i = jcnum; i < n; i++)
			{
				//把当前到达的进程筛选出来
				if (time >= a[i].arrivetime)
				{
					//从挑选出来的进程中选取服务时间最短的一个
					if (a[i].servetime < a[jcnum].servetime)
					{
						t = a[jcnum];
						a[jcnum] = a[i];
						a[i] = t;
					}
					ztgb = 1;
				}
			}
			if (ztgb == 1)
			{
				printf("\t\t\t进程  %c  开始\n\n\n\n", a[jcnum].name);
				a[jcnum].finishtime = a[jcnum].arrivetime + a[jcnum].servetime;
				a[jcnum].roundtime = a[jcnum].finishtime - a[jcnum].arrivetime;
				a[jcnum].daiquantime = a[jcnum].roundtime / a[jcnum].servetime;
				ztgb = 0;
				jcnum++;
			}
		}

		if (time == a[jcnum - 1].finishtime && a[jcnum - 1].finishtime != 0)
		{
			printf("\t\t\t进程  %c  完成\n\n\n\n", a[jcnum - 1].name);

			//遍历数组
			for (int i = jcnum; i < n; i++)
			{
				//把当前到达的进程筛选出来
				if (time >= a[i].arrivetime)
				{
					//从挑选出来的进程中选取服务时间最短的一个
					if (a[i].servetime < a[jcnum].servetime)
					{
						t = a[jcnum];
						a[jcnum] = a[i];
						a[i] = t;
					}
					ztgb = 1;
				}
			}
			if (ztgb == 1 || jcnum == n - 1)
			{
				printf("\t\t\t进程  %c  开始\n\n\n\n", a[jcnum].name);
				a[jcnum].finishtime = a[jcnum - 1].finishtime + a[jcnum].servetime;
				a[jcnum].roundtime = a[jcnum].finishtime - a[jcnum].arrivetime;
				a[jcnum].daiquantime = a[jcnum].roundtime / a[jcnum].servetime;
				ztgb = 0;
				jcnum++;
			}
		}
		if (time > a[n - 1].finishtime && a[n - 1].finishtime != 0)
		{
			printf("\t\t\t所有进程已加载完毕！ \n\n\n\n");
			break;
		}
		time++;
		Sleep(1000);
	}
	tjxx(n);
	}

	//信息录入
	int info()
	{
		int n = 0;
		srand(time(NULL)); //初始化随机函数
		printf("\n\t\t请输入需要的进程数：");
		scanf("%d", &n);
		printf("\n");
		for (int i = 0; i < n; i++)
		{
			printf("\t\t进程 %d\t名称:", i + 1);
			scanf("%s", &a[i].name);
			a[i].arrivetime = (float)(rand() % 5 + 1);//随机获取进程运行到达时间
			a[i].servetime = (float)(rand() % 5 + 1);//随机获取进程运行服务时间
		}
		system("cls");
		return n;
	}

	void main()
	{
		int b = 1, k;
		while (b)
		{
			system("cls");
			printf("\n\n\t\t进程调度算法\n\n");
			printf("\t\t 程序清单\n");
			printf("\t\t1… 先来先服务算法 \n");
			printf("\t\t2… 短进程优先算法 \n");
			printf("\t\t3… 退出程序 \n\n\n");
			printf("\t\t请选择：");
			scanf("%d", &k);
			switch (k)
			{
			case 1: xlxfw(info()); break;
			case 2: djcyx(info()); break;
			case 3: b = 0; break;
			default:printf("\n\t\t请输入正确的选择!\n");
			}
			if (b != 0)
			{
				printf("\n"); 
			}
		}
		
	}