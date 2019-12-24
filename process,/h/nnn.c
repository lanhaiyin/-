#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

//���̿��ƿ�(PCB)
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
char *jczt[] = { "����", "����" };//*��ʾû���ַ����Ĵ�С����

//��ӡͳ����Ϣ
void tjxx(int n)
{
	float averoundtime = 0.0f;
	float avedaiquantime = 0.0f;
	printf("��������鿴ͳ����Ϣ");
	getchar(); getchar();
	printf("\n\n��������\t����ʱ��\t����ʱ��\t���ʱ��\t��תʱ��\t��Ȩ��תʱ��");
	for (int j = 0; j < n; j++)
	{
		printf("\n %c\t\t%4.f\t\t%4.f\t\t%4.f\t\t%4.f\t\t %.2f\n", a[j].name, a[j].arrivetime, a[j].servetime, a[j].finishtime, a[j].roundtime, a[j].daiquantime);
		averoundtime += a[j].roundtime;
		avedaiquantime += a[j].daiquantime;
	}

	printf("\nƽ����תʱ��:%.2f", averoundtime / n);
	printf("\n\nƽ����Ȩ��תʱ��:%.2f\n", avedaiquantime / n);
}

void xlxfw(int n)
{
	int time = 0; //���嵱ǰʱ��
	int processnum = 0; //���嵱ǰ����ָ��
	struct PCB t; //����һ���յĽṹ��ڵ�
	int processztsy = 0; //�������״̬����

	while (1)
	{
		printf("��ǰʱ�̣�%2d\n", time);

		//����
		for (int i = 1; i < n; i++)
		{
			for (int j = 0; j < n - i; j++)
			{
				if (a[j].arrivetime > a[j + 1].arrivetime)//�ȵ�������
				{
					t = a[j];
					a[j] = a[j + 1];
					a[j + 1] = t;
				}
				if (a[j].arrivetime == a[j + 1].arrivetime)//����ͬʱ��
				{
					if (a[j].servetime > a[j + 1].servetime)//�ȽϷ���ʱ��,������ʱ��̵ķ������ȼ��ߵ�λ��
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
				printf("\t\t���� %c ����\t����״̬\n", a[k].name);
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
					printf("\t\t\t����  %c  ��ʼ\n\n\n\n", a[processnum].name);
					processnum++;
				}
			}

			if (time == a[k].finishtime && a[k].finishtime != 0)
			{
				printf("\t\t\t����  %c  ���\n\n\n\n", a[k].name);
			}

			if ((k >= 1 && time >= a[k].arrivetime && time == a[k - 1].finishtime && a[k].arrivetime != 0))
			{
				printf("\t\t\t����  %c  ��ʼ\n\n\n\n", a[k].name);
			}
		}


		if (time > a[n - 1].finishtime && a[n - 1].finishtime != 0)
		{
			printf("\t\t\t���н����ѽ����Ѽ�����ϣ� \n\n\n\n");
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
	int time = 0;//���嵱ǰʱ��
	int jcnum = 0;
	int jcztsy = 0;
	int ztgb = 0;

	//����
	for (int i = 1; i < n; i++)
	{
		for (int j = 0; j < n - i; j++)
		{
			if (a[j].arrivetime > a[j + 1].arrivetime)//�ȵ�������ȼ���
			{
				t = a[j];
				a[j] = a[j + 1];
				a[j + 1] = t;
			}
		}
	}

	while (1)
	{
		printf("��ǰʱ�̣�%d\n", time);


		//�������飬ע��ͬʱ�ﵽ�Ľ��̣����Բ���forѭ������
		for (int k = 0; k< n; k++)
		{
			//�Ƿ��н��̵ĵ���ʱ����ڵ�ǰʱ��
			if (time == a[k].arrivetime && a[k].arrivetime != 0)
			{
				//�жϵ��������ô���ʲô״̬
				if (k >= 1 && time >= a[k - 1].finishtime || k == 0)
				{
					jcztsy = 0;
				}
				else
				{
					jcztsy = 1;
				}
				printf("\t\t���� %c ����\t����״̬\n\n\n\n", a[k].name);
			}
		}

		if (jcnum == 0)
		{
			//��������
			for (int i = jcnum; i < n; i++)
			{
				//�ѵ�ǰ����Ľ���ɸѡ����
				if (time >= a[i].arrivetime)
				{
					//����ѡ�����Ľ�����ѡȡ����ʱ����̵�һ��
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
				printf("\t\t\t����  %c  ��ʼ\n\n\n\n", a[jcnum].name);
				a[jcnum].finishtime = a[jcnum].arrivetime + a[jcnum].servetime;
				a[jcnum].roundtime = a[jcnum].finishtime - a[jcnum].arrivetime;
				a[jcnum].daiquantime = a[jcnum].roundtime / a[jcnum].servetime;
				ztgb = 0;
				jcnum++;
			}
		}

		if (time == a[jcnum - 1].finishtime && a[jcnum - 1].finishtime != 0)
		{
			printf("\t\t\t����  %c  ���\n\n\n\n", a[jcnum - 1].name);

			//��������
			for (int i = jcnum; i < n; i++)
			{
				//�ѵ�ǰ����Ľ���ɸѡ����
				if (time >= a[i].arrivetime)
				{
					//����ѡ�����Ľ�����ѡȡ����ʱ����̵�һ��
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
				printf("\t\t\t����  %c  ��ʼ\n\n\n\n", a[jcnum].name);
				a[jcnum].finishtime = a[jcnum - 1].finishtime + a[jcnum].servetime;
				a[jcnum].roundtime = a[jcnum].finishtime - a[jcnum].arrivetime;
				a[jcnum].daiquantime = a[jcnum].roundtime / a[jcnum].servetime;
				ztgb = 0;
				jcnum++;
			}
		}
		if (time > a[n - 1].finishtime && a[n - 1].finishtime != 0)
		{
			printf("\t\t\t���н����Ѽ�����ϣ� \n\n\n\n");
			break;
		}
		time++;
		Sleep(1000);
	}
	tjxx(n);
	}

	//��Ϣ¼��
	int info()
	{
		int n = 0;
		srand(time(NULL)); //��ʼ���������
		printf("\n\t\t��������Ҫ�Ľ�������");
		scanf("%d", &n);
		printf("\n");
		for (int i = 0; i < n; i++)
		{
			printf("\t\t���� %d\t����:", i + 1);
			scanf("%s", &a[i].name);
			a[i].arrivetime = (float)(rand() % 5 + 1);//�����ȡ�������е���ʱ��
			a[i].servetime = (float)(rand() % 5 + 1);//�����ȡ�������з���ʱ��
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
			printf("\n\n\t\t���̵����㷨\n\n");
			printf("\t\t �����嵥\n");
			printf("\t\t1�� �����ȷ����㷨 \n");
			printf("\t\t2�� �̽��������㷨 \n");
			printf("\t\t3�� �˳����� \n\n\n");
			printf("\t\t��ѡ��");
			scanf("%d", &k);
			switch (k)
			{
			case 1: xlxfw(info()); break;
			case 2: djcyx(info()); break;
			case 3: b = 0; break;
			default:printf("\n\t\t��������ȷ��ѡ��!\n");
			}
			if (b != 0)
			{
				printf("\n"); 
			}
		}
		
	}