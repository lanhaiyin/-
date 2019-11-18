#include"arr.h"
void sqinitseqlist(pseqlist pseq,size_t capicity)//��ʼ��˳���
{
	assert(pseq);
		pseq->capicity = maxsize;
		pseq->size = 0;
	pseq->myarr= (datetype*)malloc(sizeof(datetype)*capicity);
	assert(pseq->myarr);
	if (pseq->myarr ==NULL)
		printf("����ʧ��");
	
}
void sqpushback(pseqlist pseq, datetype  date)//β�巨����Ԫ��
{
	assert(pseq);
	sqcheckcapicity( pseq);
	pseq->myarr[pseq->size] = date;
	pseq->size++;
}
 void sqcheckcapicity(pseqlist pseq)//�������������
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
void sqemptymyarr(pseqlist pseq)//�п�
{
	assert(pseq);
	if (pseq->size == 0)
		printf("˳���Ϊ��");
}

void sqprint(pseqlist pseq)//��ӡ˳���
{
	assert(pseq);
	for (int i = 0; i<(pseq-> size); i++)
	{
		printf("%d ", pseq->myarr[i]);

	}printf("\n");
}
void sqpopback(pseqlist pseq, datetype  date)//βɾ
{
	assert(pseq);
	sqemptymyarr(pseq);
	pseq->size--;
	return pseq;
}
void sqpushfront(pseqlist pseq, datetype  date)//ͷ��
{
	assert(pseq);
	sqcheckcapicity(pseq);
	for (int i = (pseq->size-1); i >=0; i--)//�Ӻ���ǰŲ
	{
		pseq->myarr[i+1] = pseq->myarr[i];
	}
	pseq->myarr[0] = date;
	pseq->size++;
}

void sqpopfront(pseqlist pseq)//ͷɾ
{
	assert(pseq);
	sqemptymyarr(pseq);//��ǰ����Ų
	for (int i = 0; i < (pseq->size); i++)
	{
		pseq->myarr[i] = pseq->myarr[i + 1];
	}
	pseq->size--;
}
void sqpushpos(pseqlist pseq, int pos,datetype date)//��posλ����
{
	assert(pseq);
	sqcheckcapicity(pseq);

	if (pos<1 || pos>pseq->size)
		printf("����λ�ò��Ϸ�\n");
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
void sqpoppos(pseqlist pseq, int pos)//��posλɾ��
{
	assert(pseq);
	sqemptymyarr(pseq);
	if (pos<1 || pos>pseq->size)
	{
		printf("ɾ��λ�ò��Ϸ�\n");
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
			printf("%d ", i); flag = 1;//�����ҵ�xԪ�ص������±�
		}
			
	}printf("\n");
	if (flag == 0)
		printf("û���ҵ���Ԫ��\n");
	
}
void sqdestory(pseqlist pseq)//����������Ŀռ�
{
	assert(pseq);
	pseq->size = 0;
	pseq->capicity = 0;
	free(pseq->myarr);
	sqemptymyarr(pseq);
	
}
void sqmodify(pseqlist pseq, int pos, datetype x)//�޸�posλ��ֵ
{
	assert(pseq);
	if (pos<1 || pos>pseq->size)
		printf("�޸�λ�ò��Ϸ�\n");
	else
	{
		pseq->myarr[pos-1] = x;
	}
	
}
void sqremove(pseqlist pseq, datetype x)//ɾ��Ԫ��
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
		printf("û�ҵ�\n");
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
void sqremoveall(pseqlist pseq, datetype x)//ɾ������xԪ��   //�����㷨���Ͻ��Ż�0
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
		printf("û�ҵ�\n");
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
		temp++;//��temp��i����һ��

	}
}

void sqbubblesort(pseqlist pseq)//ð������
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
		printf("û�ҵ�\n");
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
			printf("%d ",pseq->myarr[dst]);//ֻ�Ǵ�ӡ����ΪxԪ���±�����Ӧ��Ԫ�أ�
										//	�����src��ֵ��dst�Ϳ���ʹ��ѭ����dst��ӡ����
			src++;
		}
	}
	printf("\n");
}
void sqbinaryfind(pseqlist pseq,datetype x)//���ֲ���
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
			printf("�ҵ��ˣ��±�Ϊ%d\n",mid);
			return;
		}
	}
	printf("û���ҵ���Ԫ��\n");

}