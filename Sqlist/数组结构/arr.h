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
void initseqlist(pseqlist pseq);//��ʼ��˳���
void sqpushback(pseqlist pseq, datetype date);//β�巨����Ԫ��
void sqpopback(pseqlist pseq);//βɾ
void sqpushfront(pseqlist pseq, datetype date);//ͷ��
void sqpopfront(pseqlist pseq);//ͷɾ
void sqprint(pseqlist pseq);//��ӡ˳���
void sqcheckcapicity(pseqlist pseq);//����
void sqemptymyarr(pseqlist pseq);//�п�
void sqpushpos(pseqlist pseq,int pos, datetype date);//��posλ����
void sqpoppos(pseqlist pseq, int pos);//��posλɾ��
void sqfinddate(pseqlist pseq, datetype x);//Ѱ��xԪ�ص��±�
void sqdestory(pseqlist pseq);//����������Ŀռ�
void sqmodify(pseqlist pseq, int pos, datetype x);//�޸�posλ��ֵ
void sqremove(pseqlist pseq, datetype x);//ɾ��Ԫ��
void sqbubblesort(pseqlist pseq);//ð������
void sqremoveall(pseqlist pseq, datetype x);//ɾ������xԪ��
void sqremoveall2(pseqlist pseq, datetype x);
void sqbinaryfind(pseqlist pseq, datetype x);//���ֲ���