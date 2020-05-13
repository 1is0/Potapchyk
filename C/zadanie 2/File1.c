#pragma hdrstop
#pragma argsused
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#define N 128
/*«адание 4.2(13)
“екст в файле содержит числа, которые записаны в восьмеричной системе счислени€.
ѕреобразовать эти числа в дес€тичную систему счислени€ и записать
отредактированный текст обратно в файл.

*/
int main() {
	int i, s10, k;
	char separator[] = " ";
	char *p;
	FILE *myfile;
	myfile = fopen("hello2.txt", "a+");
	char **str = (char**)malloc(sizeof(char*));
	int n = 0;
	int h;
	while (!feof(myfile))
	{
		str[n] = (char*)malloc(sizeof(char) * 256);
		fgets(str[n], 256, myfile);
		n++;
		str = (char**)realloc(str, sizeof(char*)*(n + 1));

	}
	 fprintf(myfile,"\n\n");
	for (int j = 0; j < n; j++) {
		p = strtok(str[j], separator);
		while (p) {
			s10 = 0;
			h=0;
			int len1 = strlen(p);
			for (int i = 0; i < len1; i++) {
				switch (p[i]) {
				case '0':
					k = 0;
					break;
				case '1':
					k = 1;
					break;
				case '2':
					k = 2;
					break;
				case '3':
					k = 3;
					break;
				case '4':
					k = 4;
					break;
				case '5':
					k = 5;
					break;
				case '6':
					k = 6;
					break;
				case '7':
					k = 7;
					break;
				case '\n':
					k=0;
					continue;
				default:

				   k=0;
				   h=1;
					continue;
				}
				s10 = s10 * 8 + k;
			}
			if (h==0)
			{printf("%d ", s10);
				fprintf(myfile,"%d ",s10); }
			else
			{printf("Error");
			fprintf(myfile, "error");}
			p = strtok(NULL, separator);
		}
		printf("\n");
		fprintf(myfile,"\n");
	}
	printf("\n");
	fclose(myfile);
	int y;
	scanf("%d", &y);
	return 0;
}
