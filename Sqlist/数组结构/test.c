#include"arr.h"
#define _CRT_SECURE_NO_WARNINGS 1
int main()
{
	seqlist  s;
	
	sqinitseqlist(&s);
	sqpushback(&s,  1);//β��
	sqpushback(&s,  2);//β��
	sqpushback(&s, 3);//β��
	sqpushback(&s, 4);//β��
	sqprint(&s);
	sqpopback(&s);//βɾ
	sqprint(&s);
	sqpushfront(&s, 7);//ͷ��
	sqpushfront(&s, 8);
	sqprint(&s);
	sqpopfront(&s);//ͷɾ
	sqprint(&s);


	sqpushpos(&s, 2, 9);//��posλ�ò���
	sqprint(&s);
	sqpoppos(&s, 1);//��posλɾ��
    sqprint(&s);
	sqpushpos(&s, 2, 7);//��posλ�ò���
	sqprint(&s);
	sqpushpos(&s, 4, 7);//��posλ�ò���
	sqprint(&s);
	sqfinddate(&s, 2);
	sqfinddate(&s, 3);
	sqpushpos(&s, 5, 7);
	sqmodify(&s, 3, 55);//�޸�posλ��ֵ
	
	sqprint(&s);
	sqremove(&s, 7);//ɾ��ĳ��Ԫ��
	sqremoveall(&s,7);//ɾ������xԪ��
	sqprint(&s);
	//sqremoveall2(&s, 7);
	sqpushback(&s, 1);//β��
	sqpushback(&s, 2);//β��
	sqpushback(&s, 3);//β��
	sqpushback(&s, 4);//β��
	sqbubblesort(&s);//����
	sqprint(&s);
	sqbinaryfind(&s, 4);
	//sqprint(&s);
	//sqdestory(&s);//����������Ŀռ�
	//sqprint(&s);
}
