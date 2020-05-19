#include <stdio.h>
#include <malloc.h>
#include <string.h>
#include <math.h>
#define N 128
/*
«адача 5.1(15)
ќпределить количество делителей многоразр€дного числа. 
ƒл€ хранени€ многоразр€дного числа использовать динамический двунаправленныйс писок.
*/

/* —труктура, описывающа€ элемент двунаправленного списка */
typedef struct item {
	int digit;
	struct item* next;
	struct item* prev;
} Item;

/* —труктура, описывающа€ многоразр€дное число */
typedef struct mnumber {
	Item* head;
	Item* tail;
	int n;
} MNumber;

MNumber CreateMNumber(char* initStr);
void AddDigit(MNumber* number, int digit);
void PrintMNumber(MNumber number);
MNumber DelMNumber(MNumber n1);

int main(void) {
	char q[N];
	int i, t;
	int r;
	do {
		r = 1;
		t = 0;
		printf("\n\nVvedite mnogorazradnoe chislo:");
		scanf("%s", q);
		int len = strlen(q);
		for (i = 0; i < len; i++) {
			if (q[i] < 48 || q[i] > 57) {
				t = 1;
			}
		}
		if (t != 0) {
			continue;
		}
		MNumber a = CreateMNumber(q);
		MNumber c = DelMNumber(a);
		// PrintMNumber(a);
		PrintMNumber(c);
		// scanf("%d", &r);
	} while (t == 1 || r == 1);
}

MNumber CreateMNumber(char initStr[]) {

	MNumber number = { NULL, NULL, 0 };
	int n;
	for (n = strlen(initStr) - 1; n >= 0; n--)
		AddDigit(&number, initStr[n] - '0');
	return number;

}

/* ƒобавл€ет цифру в многоразр€дное число */
void AddDigit(MNumber* number, int digit) {
	Item* p = (Item*)malloc(sizeof(Item));
	p->digit = digit;
	p->next = p->prev = NULL;
	if (number->head == NULL)
		number->head = number->tail = p;
	else {
		number->tail->next = p;
		p->prev = number->tail;
		number->tail = p;
	}
	number->n++;
}

/* ¬озвращает количество общих делителей многоразр€дного числа */
MNumber DelMNumber(MNumber n1) {
	MNumber Del = CreateMNumber("");
	Item* p1 = n1.head;
	int pos = 0, s = 0, i = 0, k = 0, s1;
	while (p1) {
		if (p1) {
			s1 = p1->digit;
			p1 = p1->next;
		}
		else
			s1 = 0;
		s = s + s1 * pow(10, i);
		i++;
		pos = (s1 + pos) / 10;
	}
	for (int j = 1; j <= s; j++) {
		int b = s % j;
		if (b == 0) {
			k = k + 1;
		}
	}
	char z[N];
	sprintf(z, "%d", k);
	Del = CreateMNumber(z);
	return Del;
}

void PrintMNumber(MNumber number) {
	Item* p = number.tail;
	printf("\nChislo obcix delitelei: ");
	while (p) {
		printf("%d", p->digit);
		p = p->prev;
	}
}