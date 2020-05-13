#pragma hdrstop
#pragma argused
#include <conio.h>
#pragma <tchar.h>
#include <math.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Задание 4.1(13)

Ввести с клавиатуры натуральное числоn < 1000 и символ, указывающий падеж.
Вывести на экран введенное число русскими словами в заданном падеже.
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
			case 'и':
				printf(" одиннадцать");
				break;
			case 'р':
				printf(" одиннадцати");
				break;
			case 'д':
				printf(" одиннадцати");
				break;
			case 'в':
				printf(" одиннадцать");
				break;
			case 'т':
				printf(" одиннадцатью");
				break;
			case 'п':
				printf(" одиннадцати");
				break;
			}
			break;
		case '2':
			switch (*pad) {
			case 'и':
				printf(" двенадцать");
				break;
			case 'р':
				printf(" двенадцати");
				break;
			case 'д':
				printf(" двенадцати");
				break;
			case 'в':
				printf(" двенадцать");
				break;
			case 'т':
				printf(" двенадцатью");
				break;
			case 'п':
				printf(" двенадцати");
				break;
			}
			break;
		case '3':
			switch (*pad) {
			case 'и':
				printf(" тринадцать");
				break;
			case 'р':
				printf(" тринадцати");
				break;
			case 'д':
				printf(" тринадцати");
				break;
			case 'в':
				printf(" тринадцать");
				break;
			case 'т':
				printf(" тринадцатью");
				break;
			case 'п':
				printf(" тринадцати");
				break;
			}
			break;
		case '4':
			switch (*pad) {
			case 'и':
				printf(" четырнадцать");
				break;
			case 'р':
				printf(" четырнадцати");
				break;
			case 'д':
				printf(" четырнадцати");
				break;
			case 'в':
				printf(" четырнадцать");
				break;
			case 'т':
				printf(" четырнадцатью");
				break;
			case 'п':
				printf(" четырнадцати");
				break;
			}
			break;
		case '5':
			switch (*pad) {
			case 'и':
				printf(" пятнадцать");
				break;
			case 'р':
				printf(" пятнадцати");
				break;
			case 'д':
				printf(" пятнадцати");
				break;
			case 'в':
				printf(" пятнадцать");
				break;
			case 'т':
				printf(" пятнадцатью");
				break;
			case 'п':
				printf(" пятнадцати");
				break;
			}
			break;
		case '6':
			switch (*pad) {
			case 'и':
				printf(" шестнадцать");
				break;
			case 'р':
				printf(" шестнадцати");
				break;
			case 'д':
				printf(" шестнадцати");
				break;
			case 'в':
				printf(" шестнадцать");
				break;
			case 'т':
				printf(" шестнадцатью");
				break;
			case 'п':
				printf(" шестнадцати");
				break;
			}
			break;
		case '7':
			switch (*pad) {
			case 'и':
				printf(" семнадцать");
				break;
			case 'р':
				printf(" семнадцати");
				break;
			case 'д':
				printf(" семнадцати");
				break;
			case 'в':
				printf(" семнадцать");
				break;
			case 'т':
				printf(" семнадцатью");
				break;
			case 'п':
				printf(" семнадцати");
				break;
			}
			break;
		case '8':
			switch (*pad) {
			case 'и':
				printf(" восемнадцать");
				break;
			case 'р':
				printf(" восемнадцати");
				break;
			case 'д':
				printf(" восемнадцати");
				break;
			case 'в':
				printf(" восемнадцать");
				break;
			case 'т':
				printf(" восемнадцатью");
				break;
			case 'п':
				printf(" восемнадцати");
				break;
			}
			break;
		case '9':
			switch (*pad) {
			case 'и':
				printf(" девятнадцать");
				break;
			case 'р':
				printf(" девятнадцати");
				break;
			case 'д':
				printf(" девятнадцати");
				break;
			case 'в':
				printf(" девятнадцать");
				break;
			case 'т':
				printf(" девятнадцатью");
				break;
			case 'п':
				printf(" девятнадцати");
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
		case 'и':
			printf(" один");
			break;
		case 'р':
			printf(" одного");
			break;
		case 'д':
			printf(" одному");
			break;
		case 'в':
			printf(" один");
			break;
		case 'т':
			printf(" одним");
			break;
		case 'п':
			printf(" одном");
			break;
		}
		break;
	case '2':
		switch (*pad) {
		case 'и':
			printf(" два");
			break;
		case 'р':
			printf(" двух");
			break;
		case 'д':
			printf(" двум");
			break;
		case 'в':
			printf(" два");
			break;
		case 'т':
			printf(" двумя");
			break;
		case 'п':
			printf(" двух");
			break;
		}
		break;

	case '3':
		switch (*pad) {
		case 'и':
			printf(" три");
			break;
		case 'р':
			printf(" трёх");
			break;
		case 'д':
			printf(" трём");
			break;
		case 'в':
			printf(" три");
			break;
		case 'т':
			printf(" тремя");
			break;
		case 'п':
			printf(" трёх");
			break;
		}
		break;
	case '4':
		switch (*pad) {
		case 'и':
			printf(" четыре");
			break;
		case 'р':
			printf(" четырёх");
			break;
		case 'д':
			printf(" четырём");
			break;
		case 'в':
			printf(" четыре");
			break;
		case 'т':
			printf(" четырьмя");
			break;
		case 'п':
			printf(" четырёх");
			break;
		}
		break;
	case '5':
		switch (*pad) {
		case 'и':
			printf(" пять");
			break;
		case 'р':
			printf(" пяти");
			break;
		case 'д':
			printf(" пяти");
			break;
		case 'в':
			printf(" пять");
			break;
		case 'т':
			printf(" пятью");
			break;
		case 'п':
			printf(" пяти");
			break;
		}
		break;
	case '6':
		switch (*pad) {
		case 'и':
			printf(" шесть");
			break;
		case 'р':
			printf(" шести");
			break;
		case 'д':
			printf(" шести");
			break;
		case 'в':
			printf(" шесть");
			break;
		case 'т':
			printf(" шестью");
			break;
		case 'п':
			printf(" шести");
			break;
		}
		break;
	case '7':
		switch (*pad) {
		case 'и':
			printf(" семь");
			break;
		case 'р':
			printf(" семи");
			break;
		case 'д':
			printf(" семи");
			break;
		case 'в':
			printf(" семь");
			break;
		case 'т':
			printf(" семью");
			break;
		case 'п':
			printf(" семи");
			break;
		}
	case '8':
		switch (*pad) {
		case 'и':
			printf(" восемь");
			break;
		case 'р':
			printf(" восьми");
			break;
		case 'д':
			printf(" восьми");
			break;
		case 'в':
			printf(" восемь");
			break;
		case 'т':
			printf(" восьмью");
			break;
		case 'п':
			printf(" восьми");
			break;
		}
	case '9':
		switch (*pad) {
		case 'и':
			printf(" девять");
			break;
		case 'р':
			printf(" девяти");
			break;
		case 'д':
			printf(" девяти");
			break;
		case 'в':
			printf(" девять");
			break;
		case 'т':
			printf(" девятью");
			break;
		case 'п':
			printf(" девяти");
			break;
		}
	}

}

void dvuhznach(char *chi, char *pad) {
	switch (*chi) {
	case '2':
		switch (*pad) {
		case 'и':
			printf(" двадцать");
			break;
		case 'р':
			printf(" двадцати");
			break;
		case 'д':
			printf(" двадцати");
			break;
		case 'в':
			printf(" двадцать");
			break;
		case 'т':
			printf(" двадцатью");
			break;
		case 'п':
			printf(" двадцати");
			break;
		}
		break;

	case '3':
		switch (*pad) {
		case 'и':
			printf(" тридцать");
			break;
		case 'р':
			printf(" тридцати");
			break;
		case 'д':
			printf(" тридцати");
			break;
		case 'в':
			printf(" тридцать");
			break;
		case 'т':
			printf(" тридцатью");
			break;
		case 'п':
			printf(" тридцати");
			break;
		}
		break;
	case '4':
		switch (*pad) {
		case 'и':
			printf(" сорок");
			break;
		case 'р':
			printf(" сорока");
			break;
		case 'д':
			printf(" сорока");
			break;
		case 'в':
			printf(" сорок");
			break;
		case 'т':
			printf(" сорока");
			break;
		case 'п':
			printf(" сорока");
			break;
		}
		break;
	case '5':
		switch (*pad) {
		case 'и':
			printf(" пятьдесят");
			break;
		case 'р':
			printf(" пятидесяти");
			break;
		case 'д':
			printf(" пятидесяти");
			break;
		case 'в':
			printf(" пятьдесят");
			break;
		case 'т':
			printf(" пятьюдесятью");
			break;
		case 'п':
			printf(" пятидесяти");
			break;
		}
		break;
	case '6':
		switch (*pad) {
		case 'и':
			printf(" шестьдесят");
			break;
		case 'р':
			printf(" шестидесяти");
			break;
		case 'д':
			printf(" шестидесяти");
			break;
		case 'в':
			printf(" шестьдесят");
			break;
		case 'т':
			printf(" шестьюдесятью");
			break;
		case 'п':
			printf(" шестидесяти");
			break;
		}
		break;
	case '7':
		switch (*pad) {
		case 'и':
			printf(" семьдесят");
			break;
		case 'р':
			printf(" семидесяти");
			break;
		case 'д':
			printf(" семидесяти");
			break;
		case 'в':
			printf(" семьдесят");
			break;
		case 'т':
			printf(" семьюдесятью");
			break;
		case 'п':
			printf(" семидесяти");
			break;
		}
	case '8':
		switch (*pad) {
		case 'и':
			printf(" восемьдесят");
			break;
		case 'р':
			printf(" восьмидесяти");
			break;
		case 'д':
			printf(" восьмидесяти");
			break;
		case 'в':
			printf(" восемьдесят");
			break;
		case 'т':
			printf(" восьмьюдесятью");
			break;
		case 'п':
			printf(" восьмидесяти");
			break;
		}
	case '9':
		switch (*pad) {
		case 'и':
			printf(" девяносто");
			break;
		case 'р':
			printf(" девяноста");
			break;
		case 'д':
			printf(" девяноста");
			break;
		case 'в':
			printf(" девяносто");
			break;
		case 'т':
			printf(" девяноста");
			break;
		case 'п':
			printf(" девяноста");
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
			printf("\nВведите натуральное число:");
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
			printf("Введите первую букву падежа:");
			scanf("%s", padej);
			len2 = mystrlen(padej);
			if (len2 < 2) {
				j = 0;
				if (padej[j] != 'и' && padej[j] != 'в' && padej[j]
					!= 'д' && padej[j] != 'п' && padej[j] != 'р' && padej[j]
					!= 'т') {
					proverka = 1;
				}
			}
			else
				proverka = 1;
		}
		while (proverka == 1);

		if (len1 == 3) {
			switch (padej[j]) {
			case 'и':
				switch (chislo[0]) {
				case '1':
					printf("Стo");
					break;
				case '2':
					printf("Двести");
					break;
				case '3':
					printf("Триста");
					break;
				case '4':
					printf("Четыреста");
					break;
				case '5':
					printf("Пятьсот");
					break;
				case '6':
					printf("Шестьсот");
					break;
				case '7':
					printf("Семьсот");
					break;
				case '8':
					printf("Восемьсот");
					break;
				case '9':
					printf("Девятьсот");
					break;
				}
				break;
			case 'р':
				switch (chislo[0]) {
				case '1':
					printf("Ста");
					break;
				case '2':
					printf("Двухсот");
					break;
				case '3':
					printf("Трёхсот");
					break;
				case '4':
					printf("Четырёхсот");
					break;
				case '5':
					printf("Пятисот");
					break;
				case '6':
					printf("Шестисот");
					break;
				case '7':
					printf("Семисот");
					break;
				case '8':
					printf("Восьмисот");
					break;
				case '9':
					printf("Девятисот");
					break;
				}
				break;
			case 'д':
				switch (chislo[0]) {
				case '1':
					printf("Ста");
					break;
				case '2':
					printf("Двумстам");
					break;
				case '3':
					printf("Трёмстам");
					break;
				case '4':
					printf("Четырёмстам");
					break;
				case '5':
					printf("Пятистам");
					break;
				case '6':
					printf("Шестистам");
					break;
				case '7':
					printf("Семистам");
					break;
				case '8':
					printf("Восьмистам");
					break;
				case '9':
					printf("Девятистам");
					break;
				}
				break;
			case 'в':
				switch (chislo[0]) {
				case '1':
					printf("Стo");
					break;
				case '2':
					printf("Двести");
					break;
				case '3':
					printf("Триста");
					break;
				case '4':
					printf("Четыреста");
					break;
				case '5':
					printf("Пятьсот");
					break;
				case '6':
					printf("Шестьсот");
					break;
				case '7':
					printf("Семьсот");
					break;
				case '8':
					printf("Восемьсот");
					break;
				case '9':
					printf("Девятьсот");
					break;
				}
				break;
			case 'т':
				switch (chislo[0]) {
				case '1':
					printf("Ста");
					break;
				case '2':
					printf("Двумястами");
					break;
				case '3':
					printf("Тремястами");
					break;
				case '4':
					printf("Четырьмястами");
					break;
				case '5':
					printf("Пятьюстами");
					break;
				case '6':
					printf("Шестьюстами");
					break;
				case '7':
					printf("Семьюстами");
					break;
				case '8':
					printf("Восемьюстами");
					break;
				case '9':
					printf("Девятьюстами");
					break;
				}
				break;
			case 'п':
				switch (chislo[0]) {
				case '1':
					printf("Ста");
					break;
				case '2':
					printf("Двухстах");
					break;
				case '3':
					printf("Трёхстах");
					break;
				case '4':
					printf("Четырёхстах");
					break;
				case '5':
					printf("Пятистах");
					break;
				case '6':
					printf("Шестистах ");
					break;
				case '7':
					printf("Семистах");
					break;
				case '8':
					printf("Восьмистах");
					break;
				case '9':
					printf("Девятистах");
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
