using System;
namespace ConsoleApp3
{
    class Program
    {    static int[,] vvod(int n,int m) //Заполнение матрицы
        {
            int[,] mas = new int[n, m];
            Console.WriteLine();
            Console.WriteLine("Заполните матрицу по строкам");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]:");
                    while (!int.TryParse(Console.ReadLine(), out mas[i,j]))
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число ");
                        Console.Write("mas[" + i + "," + j + "]:");
                    }

                    
                    
                }
            }
            Console.WriteLine();
            return mas;
        }
        static void vivod(int n, int m,int [,]mas) //Вывод матрицы
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(" " + mas[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
       static void dop(int [,]mas, int [,]p, int i, int j, int n) //нахождение алгебраических дополнений
        {
            int ki, kj, di, dj;
            di = 0;
            for (ki = 0; ki < n - 1; ki++) { // проверка индекса строки
                if (ki == i) di = 1;
                dj = 0;
                for (kj = 0; kj < n - 1; kj++) { // проверка индекса столбца
                    if (kj == j) dj = 1;
                    p[ki,kj] = mas[ki + di,kj + dj];
                }
            }
        }
        static int Determinant(int[,] mas, int n) //нахожение определителя
        {
            int i, j = 0, d = 0, k = 1, t = n - 1;
            int[,] p = new int[n, n];
            if (n < 1)
            {
                Console.Write("Вычислить определитель невозможно!");
            }
            if (n == 1)
            {
                d = mas[0, 0];
                return (d);
            }

            if (n == 2)
            {
                d = mas[0, 0] * mas[1, 1] - (mas[1, 0] * mas[0, 1]);
                return (d);
            }
            if (n > 2)
            {
                for (i = 0; i < n; i++)
                {
                    dop(mas, p, i, 0, n);
                    Console.Write(mas[i,j]+"\n");
                    vivod(t, t, p);
                    d = d + k * mas[i, 0] * Determinant(p, t);
                    k = -k;
                }
            }
            return (d);
        }   
        static void Main(string[] args)
        {
            int selection;
            bool var = true;
            Console.Write("Введите количество строк ");
            int n1, m1;
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }      
            Console.Write("Введите количество столбцов ");
            while (!int.TryParse(Console.ReadLine(), out m1))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число ");
            }
            int[,] mas1 = new int[n1, m1];
            mas1 = vvod(n1, m1);
            Console.WriteLine("Первая матрица:");
            vivod(n1, m1, mas1);
            Console.Clear();
            Console.Write("Введите количество строк ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов ");
            int m2 = int.Parse(Console.ReadLine());
            int[,] mas2 = new int[n2, m2];
            mas2 = vvod(n2, m2);
            Console.WriteLine("Вторая матрица:");
            vivod(n2, m2, mas2);
            Console.Clear();
            
             selection = 0;
            do {
                Console.WriteLine("Веберите действие которое хотите выполнить:");
                Console.WriteLine("1-Сумма матриц");
                Console.WriteLine("2-Разность матриц");
                Console.WriteLine("3-Произведение матриц");
                Console.WriteLine("4-Умножение матрицы на число");
                Console.WriteLine("5-Транспанированние матрицы");
                Console.WriteLine("6-Нахождение определителя");
                Console.WriteLine("7-Выход из программы\n");
                while (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число ");
                }

               // selection = int.Parse(Console.ReadLine());
                
                switch (selection)
                {

                    case 1: //сумма матриц
                        Console.Clear();
                       if (n1==n2 && m1 == m2) { 
                        Console.WriteLine("Первая матрица:");
                        vivod(n1, m1, mas1);
                        Console.WriteLine("Вторая матрица:");
                        vivod(n2, m2, mas2);
                        Console.WriteLine("Сумма матриц:");
                        int[,] mass3 = new int[n1, m1];
                            for (int i = 0; i < n1; i++)
                            {
                                for (int j = 0; j < m1; j++)
                                {
                                    mass3[i, j] = mas1[i, j] + mas2[i, j];
                                    Console.Write(" " + mass3[i, j]);
                                }
                                Console.WriteLine();
                            }
                            
                        }
                        else
                            {
                                Console.WriteLine("Сумма невозможна");
                            }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        if (n1 == n2 && m1 == m2)
                        {
                            Console.WriteLine("Первая матрица:");
                            vivod(n1, m1, mas1);
                            Console.WriteLine("Вторая матрица:");
                            vivod(n2, m2, mas2);
                            Console.WriteLine("Разность матриц:");
                            int[,] mass7 = new int[n1, m1];
                            for (int i = 0; i < n1; i++)
                            {
                                for (int j = 0; j < m1; j++)
                                {
                                    mass7[i, j] = mas1[i, j] - mas2[i, j];
                                    Console.Write(" " + mass7[i, j]);
                                }
                                Console.WriteLine();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Разность невозможна");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3: //произведеение матриц
                        Console.Clear();
                        if (m1 == n2)
                        {

                            Console.WriteLine("Первая матрица:");
                            vivod(n1, m1, mas1);
                            Console.WriteLine("Вторая матрица:");
                            vivod(n2, m2, mas2);
                            Console.WriteLine("Произведение матриц:");
                            int[,] mass4 = new int[n1, m2];
                            for (int i = 0; i < n1; i++)
                            {
                                for (int j = 0; j < m2; j++)
                                {
                                    mass4[i, j] = 0;
                                    for (int k = 0; k < m1; k++)
                                    {
                                        mass4[i, j] += mas1[i, k] * mas2[k, j];

                                    }
                                    Console.Write(" " + mass4[i, j]);
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Произведение невозможно");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4: //умножение матрицы на число
                        Console.Clear();
                        {
                            Console.WriteLine("1-Умнодение первой матрицы на число");
                            Console.WriteLine("2-Умнодение второй матрицы на число\n");
                            int selection2 = int.Parse(Console.ReadLine());
                            switch (selection2)
                            {
                                case 1:
                                    Console.WriteLine("Введите число");
                                    int chislo1 = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Первая матрица:");
                                    vivod(n1, m1, mas1);
                                    Console.WriteLine($"Ваше число: {chislo1}");
                                    Console.WriteLine("Произведение матрциы на число:");
                                    int[,] mass5 = new int[n1, m1];
                                    for (int i = 0; i < n1; i++)
                                    {
                                        for (int j = 0; j < m1; j++)
                                        {
                                            mass5[i, j] = chislo1 * mas1[i, j];
                                            Console.Write(" " + mass5[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Введите число");
                                    int chislo2 = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Вторая матрица:");
                                    vivod(n2, m2, mas2);
                                    Console.WriteLine($"Ваше число: {chislo2}");
                                    Console.WriteLine("Произведение матрциы на число:");
                                    int[,] mass6 = new int[n2, m2];
                                    for (int i = 0; i < n2; i++)
                                    {
                                        for (int j = 0; j < m2; j++)
                                        {
                                            mass6[i, j] = chislo2 * mas2[i, j];
                                            Console.Write(" " + mass6[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        Console.Clear();
                        break;
                    case 5: //транспанирование матрицы
                        Console.Clear();
                        {
                            Console.WriteLine("1-Транспанирование первой матрицы");
                            Console.WriteLine("2-Транспанирование второй матрицы\n");
                            int selection3 = int.Parse(Console.ReadLine());
                            switch (selection3)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Первая матрица:");
                                    vivod(n1, m1, mas1);
                                    Console.WriteLine("Транспанированная матрица:");
                                    int[,] trans1 = new int[m1, n1];
                                    for (int i = 0; i < m1; i++)
                                    {
                                        for (int j = 0; j < n1; j++)
                                        {
                                            trans1[i, j] = mas1[j, i];
                                            Console.Write(" " + trans1[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Вторая матрица:");
                                    vivod(n2, m2, mas2);
                                    Console.WriteLine("Транспанированная матрица:");
                                    int[,] trans2 = new int[m2, n2];
                                    for (int i = 0; i < m2; i++)
                                    {
                                        for (int j = 0; j < n2; j++)
                                        {
                                            trans2[i, j] = mas2[j, i];
                                            Console.Write(" " + trans2[i, j]);
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        Console.Clear();
                        break;
                   case 6: //определитель матрицы
                        Console.Clear();
                        {
                            Console.WriteLine("1-Определитель первой матрицы");
                            Console.WriteLine("2-Определитель второй матрицы\n");
                            int selection4 = int.Parse(Console.ReadLine());
                            switch (selection4)
                            {
                                case 1:
                                    Console.Clear();
                                    if (n1 == m1)
                                    {
                                        Console.WriteLine("Первая матрица:");
                                        vivod(n1, m1, mas1);
                                        Console.WriteLine("определитель:");
                                        int d;
                                        int[,] opr1 = new int[n1, m1];
                                        opr1 = mas1;
                                        d = Determinant(opr1, n1);
                                        Console.Write(d);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вычислить определитель невозможно!");
                                    }
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    if (n2 == m2)
                                    {
                                        Console.WriteLine("Вторая матрица:");
                                        vivod(n2, m2, mas2);
                                        Console.WriteLine("определитель:");
                                        int d2;
                                        int[,] opr2 = new int[n2, m2];
                                        opr2 = mas2;
                                        d2 = Determinant(opr2, n2);
                                        Console.Write(d2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вычислить определитель невозможно");
                                    }
                                    Console.ReadLine();
                                    break;
                        }
                        }
                            Console.Clear();
                            break;
                        
                    case 7: //выход из программы
                      if (selection == 7)
                    var = false;
                        break;
                    default: //ошибка выбора
                        Console.WriteLine("Попробуй снова");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                } 
                
            } while (var); Console.Clear();
            }
    }
}