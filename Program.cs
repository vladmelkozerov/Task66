// Задача 66 Устройство для вывода суммы натуральных элементов от М до N
Console.WriteLine("Введите натуральное число M");
int M=Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите натуральное число N");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Натуральные числа от 1 до "+N);
int GetNatNumbersSum(int M1, int N1)
    {
        if (M1>N1) return 0;
        else return M1+GetNatNumbersSum(M1+1,N1);
    }
Console.WriteLine("Сумма натуральных чисел от "+M+" до "+N+" составляет "+GetNatNumbersSum(M,N));
