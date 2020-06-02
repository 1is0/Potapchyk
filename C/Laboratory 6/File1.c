/*
 5.2(15).¬ текстовом файле записаны целые числа.
 ѕостроить сбалансированное бинарное дерево, вкотором количество
 левых и правых потомков у каждой вершины отличаетс€ неболее чем на единицу.
*/
#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>

typedef struct Tree {
	int data;
	struct Tree* left;
	struct Tree* right;
}Tree;

void Balance(struct Tree** p, int n, int k, int* a) {
	if (n == k) {
		*p = NULL;
		return;
	}
	else {
		int q = (n + k) / 2;
		*p = (struct Tree*)malloc(sizeof(struct Tree));
		(*p)->data = a[q];
		Balance(&(*p)->left, n, q, a);
		Balance(&(*p)->right, q + 1, k, a);
	}
}

void Tree_preorder(struct Tree* root) {
	if (!root)
		return;

	printf("%d", root->data);

	printf("(");
	Tree_preorder(root->left);
	printf(",");
	Tree_preorder(root->right);
	printf(")");
}

void Sort(int* num, int size) {
	for (int i = 0; i < size - 1; i++) {
		for (int j = (size - 1); j > i; j--) {
			if (num[j - 1] > num[j]) {
				int temp = num[j - 1];
				num[j - 1] = num[j];
				num[j] = temp;
			}
		}
	}
}

void Del_All(struct Tree* t) {
	if (t != NULL) {
		Del_All(t->left);
		Del_All(t->right);
		free(t);
	}
}

 void Print(struct Tree* p, int level) {
	if (p) {
		Print(p->right, level + 2);
		for (int i = 0; i < level; i++)
		printf("  ");
		printf("%d \n", p->data);
		Print(p->left, level + 2);
	}
}

int main() {
	 Tree *root = NULL;
	FILE *fp = fopen("hello.txt", "r");
	if (!fp) {
	exit(1);
	}
	int index = 1;
	int* arr;
	while (!feof(fp)) {
		if (index == 1) {
			if (!(arr = (int*)malloc(sizeof(int)))) {
				printf("Can't allocate memory\n");
				exit(1);
			}

		}
		else if (index > 1) {
			if (!(arr = (int*)realloc(arr, sizeof(int) * index))) {
				printf("Can't allocate memory\n");
				exit(1);
			}
		}
		fscanf(fp, "%d", &(arr[index - 1]));
		index++;
	}
	index--;
	Sort(arr, index);
	Balance(&root, 0, index, arr);
	Tree_preorder(root);
	printf("\n");
	Print(root, 0);
	Del_All(root);
	free(arr);
	fclose(fp);
	getch();
	return 0;
}
