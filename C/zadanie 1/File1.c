#pragma hdrstop
#pragma argused
#include <conio.h>
#pragma <tchar.h>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* ������� 4.1(13)

������ � ���������� ����������� �����n < 1000 � ������, ����������� �����.
������� �� ����� ��������� ����� �������� ������� � �������� ������.
*/
int mystrlen(char *s) {
	int n;
	for (n = 0; s[n]; n++);
	return n;
}

void drugie(char *chi, char *chis, char *pad) {
	switch (*chi) {
	case '1':
		switch (*chis) {
		case '1':
			switch (*pad) {
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" �����������");
				break;
			}
			break;
		case '2':
			switch (*pad) {
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ����������");
				break;
			}
			break;
		case '3':
			switch (*pad) {
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ����������");
				break;
			}
			break;
		case '4':
			switch (*pad) {
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" �������������");
				break;
			case '�':
				printf(" ������������");
				break;
			}
			break;
		case '5':
			switch (*pad) {
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ����������");
				break;
			}
			break;
		case '6':
			switch (*pad) {
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" �����������");
				break;
			}
			break;
		case '7':
			switch (*pad) {
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" ����������");
				break;
			case '�':
				printf(" �����������");
				break;
			case '�':
				printf(" ����������");
				break;
			}
			break;
		case '8':
			switch (*pad) {
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" �������������");
				break;
			case '�':
				printf(" ������������");
				break;
			}
			break;
		case '9':
			switch (*pad) {
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" ������������");
				break;
			case '�':
				printf(" �������������");
				break;
			case '�':
				printf(" ������������");
				break;
			}
			break;

		}
		break;
	}

}

void odnoznach(char *chi, char *pad) {
	switch (*chi) {
	case '1':
		switch (*pad) {
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" �����");
			break;
		}
		break;
	case '2':
		switch (*pad) {
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ����");
			break;
		}
		break;

	case '3':
		switch (*pad) {
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" ���");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ���");
			break;
		}
		break;
	case '4':
		switch (*pad) {
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ������");
			break;
		}
		break;
	case '5':
		switch (*pad) {
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ����");
			break;
		}
		break;
	case '6':
		switch (*pad) {
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" �����");
			break;
		}
		break;
	case '7':
		switch (*pad) {
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" ����");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ����");
			break;
		}
	case '8':
		switch (*pad) {
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" �������");
			break;
		case '�':
			printf(" ������");
			break;
		}
	case '9':
		switch (*pad) {
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" �������");
			break;
		case '�':
			printf(" ������");
			break;
		}
	}

}

void dvuhznach(char *chi, char *pad) {
	switch (*chi) {
	case '2':
		switch (*pad) {
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ��������");
			break;
		}
		break;

	case '3':
		switch (*pad) {
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ��������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ��������");
			break;
		}
		break;
	case '4':
		switch (*pad) {
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" �����");
			break;
		case '�':
			printf(" ������");
			break;
		case '�':
			printf(" ������");
			break;
		}
		break;
	case '5':
		switch (*pad) {
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ������������");
			break;
		case '�':
			printf(" ����������");
			break;
		}
		break;
	case '6':
		switch (*pad) {
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" �����������");
			break;
		case '�':
			printf(" �����������");
			break;
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" �������������");
			break;
		case '�':
			printf(" �����������");
			break;
		}
		break;
	case '7':
		switch (*pad) {
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" ����������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ������������");
			break;
		case '�':
			printf(" ����������");
			break;
		}
	case '8':
		switch (*pad) {
		case '�':
			printf(" �����������");
			break;
		case '�':
			printf(" ������������");
			break;
		case '�':
			printf(" ������������");
			break;
		case '�':
			printf(" �����������");
			break;
		case '�':
			printf(" ��������������");
			break;
		case '�':
			printf(" ������������");
			break;
		}
	case '9':
		switch (*pad) {
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ���������");
			break;
		case '�':
			printf(" ���������");
			break;
		}
	}
}

int main() {
	system("chcp 1251");
	system("cls");
	int a, proverka, len1, len2;
	char chislo[10];
	char padej[2];
	int j = 0;
	int var = 1;
	do {
		do {
			proverka = 0;
			printf("\n������� ����������� �����:");
			scanf("%s", chislo);
			len1 = mystrlen(chislo);
			if (len1 < 4) {
				for (int i = 0; i < len1; i++) {
					if (chislo[i] < 48 || chislo[i] > 57 || chislo[0] == '0') {
						proverka = 1;

					}
				}
			}
			else
				proverka = 1;
		}
		while (proverka == 1);
		do {
			proverka = 0;
			printf("������� ������ ����� ������:");
			scanf("%s", padej);
			len2 = mystrlen(padej);
			if (len2 < 2) {
				j = 0;
				if (padej[j] != '�' && padej[j] != '�' && padej[j]
					!= '�' && padej[j] != '�' && padej[j] != '�' && padej[j]
					!= '�') {
					proverka = 1;
				}
			}
			else
				proverka = 1;
		}
		while (proverka == 1);

		if (len1 == 3) {
			switch (padej[j]) {
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("��o");
					break;
				case '2':
					printf("������");
					break;
				case '3':
					printf("������");
					break;
				case '4':
					printf("���������");
					break;
				case '5':
					printf("�������");
					break;
				case '6':
					printf("��������");
					break;
				case '7':
					printf("�������");
					break;
				case '8':
					printf("���������");
					break;
				case '9':
					printf("���������");
					break;
				}
				break;
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("���");
					break;
				case '2':
					printf("�������");
					break;
				case '3':
					printf("������");
					break;
				case '4':
					printf("���������");
					break;
				case '5':
					printf("�������");
					break;
				case '6':
					printf("��������");
					break;
				case '7':
					printf("�������");
					break;
				case '8':
					printf("���������");
					break;
				case '9':
					printf("���������");
					break;
				}
				break;
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("���");
					break;
				case '2':
					printf("��������");
					break;
				case '3':
					printf("�������");
					break;
				case '4':
					printf("����������");
					break;
				case '5':
					printf("��������");
					break;
				case '6':
					printf("���������");
					break;
				case '7':
					printf("��������");
					break;
				case '8':
					printf("����������");
					break;
				case '9':
					printf("����������");
					break;
				}
				break;
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("��o");
					break;
				case '2':
					printf("������");
					break;
				case '3':
					printf("������");
					break;
				case '4':
					printf("���������");
					break;
				case '5':
					printf("�������");
					break;
				case '6':
					printf("��������");
					break;
				case '7':
					printf("�������");
					break;
				case '8':
					printf("���������");
					break;
				case '9':
					printf("���������");
					break;
				}
				break;
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("���");
					break;
				case '2':
					printf("����������");
					break;
				case '3':
					printf("����������");
					break;
				case '4':
					printf("�������������");
					break;
				case '5':
					printf("����������");
					break;
				case '6':
					printf("�����������");
					break;
				case '7':
					printf("����������");
					break;
				case '8':
					printf("������������");
					break;
				case '9':
					printf("������������");
					break;
				}
				break;
			case '�':
				switch (chislo[0]) {
				case '1':
					printf("���");
					break;
				case '2':
					printf("��������");
					break;
				case '3':
					printf("�������");
					break;
				case '4':
					printf("����������");
					break;
				case '5':
					printf("��������");
					break;
				case '6':
					printf("��������� ");
					break;
				case '7':
					printf("��������");
					break;
				case '8':
					printf("����������");
					break;
				case '9':
					printf("����������");
					break;
				}
				break;
			}
			if (chislo[1] == '1') {
				drugie(&chislo[1], &chislo[2], &padej[0]);
			}
			else {
				dvuhznach(&chislo[1], &padej[0]);
				odnoznach(&chislo[2], &padej[0]);
			}
		}
		if (len1 == 2) {
			if (chislo[0] == '1') {
				drugie(&chislo[0], &chislo[1], &padej[0]);
			}
			else {
				dvuhznach(&chislo[0], &padej[0]);
				odnoznach(&chislo[1], &padej[0]);
			}
		}
		if (len1 == 1) {
			odnoznach(&chislo[0], &padej[0]);
		}
	}
	while (var == 1);
	scanf("%d", &a);
	return 0;
}
