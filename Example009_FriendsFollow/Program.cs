// Friends - following one another

int runs = 0;                    // (раз) счетчик (количество раз бегает собака от одного друга к другому)
int friend = 1;                  // старт движения и расчеты от первого друга
double distance = 10;            // (км) начальное расстояние между друзьями
double meeting_distance = 0.01;  // (км) предельное расстояние при котором алгоритм выводит количество
double moving_time = 0;          // (ч) время затраченное на перемещение
double speed_first = 2;          // (км/ч) скорость первого друга
double speed_second = 1;         // (км/ч) скорость второго друга
double speed_dog = 5;            // (км/ч) скорость собаки

while (distance > meeting_distance)
{
    if (friend == 1)
    {
        moving_time = distance / (speed_dog - speed_second);
        friend = 2;
    }
    else
    {
        moving_time = distance / (speed_dog + speed_first);
        friend = 1;
    }
    distance = distance - (speed_first - speed_second) * moving_time;

    if (distance > meeting_distance)  // дополнительная проверка чтобы не считать последний не полный пробег собаки
        runs += 1;

}
Console.Write("Собака сделала " + runs + " полных пробега от одного друга до другого.");
