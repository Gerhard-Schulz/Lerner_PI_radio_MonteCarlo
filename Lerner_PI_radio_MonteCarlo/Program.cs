Random random = new Random();
long a = 100; //Радиус
while (a < 1e7) //Перебор значений радиуса
{
    Console.WriteLine("\n Радиус | Кол-во точек | ПИ");
    double totalPoints = a; //Общее количество точек
    while (totalPoints <= 1e8) //Перебор значения количества точек
    {
        int pointsInsideCircle = 0; //Количество точек, попавших в круг 
        int i = 0;
        while (i < totalPoints)
        {
            double x = random.NextDouble(); //Cлучайная координата X от 0 до 1
            double y = random.NextDouble(); //Cлучайная координата Y от 0 до 1                                      
            if (x * x + y * y <= 1) //Проверяем, попадает ли точка в единичную окружность
            {
                pointsInsideCircle++;
            }
            i++;
        }
        //Вычисляем приближенное значение числа Пи
        double pi = 4.0 * pointsInsideCircle / totalPoints;
        totalPoints *= 2; //Увеличиваем количество точек вдвое
        Console.WriteLine("\n {0} | {1} | {2}", a, totalPoints, pi);
    }
    Console.WriteLine("\n=========================================");
    a *= 2; //Увеличиваем радиус вдвое
}