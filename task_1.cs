Console.WriteLine("Введите дату рождения в формате DD.MM.YYYY: ");
string BiDay = Console.ReadLine();
string[] BiDay2 = BiDay.Split('.', 3);
int day = Convert.ToInt32(BiDay2[0]);
int month = Convert.ToInt32(BiDay2[1]);
int year = Convert.ToInt32(BiDay2[2]);
if (BiDay.Length!= 10 || (BiDay[2] != '.' && BiDay[5] != '.') || BiDay[7] < 9 || (day < 1 || day > 31) || (month < 1 || month > 12))
{
    Console.WriteLine("Неверный формат или значение. \n Введите дату рождения в корректном формате (DD.MM.YYYY)");
    return;
}
else
{
    string[] animal = ["Крыса", "Бык", "Тигр", "Кролик", "Дракон", "Змея", "Лошадь", "Обезьяна", "Петух", "Собака", "Свинья"];
    string[] element = ["Металл", "Вода", "Дерево", "Огонь", "Земля"];
    int x = year - 1900;
    while (x >= 12)
    {
        x = x - 12;
    }
    int y = year - 1900;
    while (y >= 10)
    {
        y = y - 10;
    }
    Console.WriteLine("Ваш знак зодиака: ");

    switch (month)
    {
        case 1:
            if (day <= 20)
            {
                Console.WriteLine("Козерог");
            }
            else
            {
                Console.WriteLine("Водолей");
            }
            break;

        case 2:
            if (day <= 18)
            {
                Console.WriteLine("Водолей");
            }
            else
            {
                Console.WriteLine("Рыбы");
            }
            break;

        case 3:
            if (day <= 20)
            {
                Console.WriteLine("Рыбы");
            }
            else
            {
                Console.WriteLine("Овен");
            }
            break;

        case 4:
            if (day <= 20)
            {
                Console.WriteLine("Овен");
            }
            else
            {
                Console.WriteLine("Телец");
            }
            break;

        case 5:
            if (day <= 20)
            {
                Console.WriteLine("Телец");
            }
            else
            {
                Console.WriteLine("Близнецы");
            }
            break;

        case 6:
            if (day <= 21)
            {
                Console.WriteLine("Близнецы");
            }
            else
            {
                Console.WriteLine("Рак");
            }
            break;

        case 7:
            if (day <= 22)
            {
                Console.WriteLine("Рак");
            }
            else
            {
                Console.WriteLine("Лев");
            }
            break;

        case 8:
            if (day <= 22)
            {
                Console.WriteLine("Лев");
            }
            else
            {
                Console.WriteLine("Дева");
            }
            break;

        case 9:
            if (day <= 23)
            {
                Console.WriteLine("Дева");
            }
            else
            {
                Console.WriteLine("Весы");
            }
            break;

        case 10:
            if (day <= 23)
            {
                Console.WriteLine("Весы");
            }
            else
            {
                Console.WriteLine("Скорпион");
            }
            break;

        case 11:
            if (day <= 22)
            {
                Console.WriteLine("Скорпион");
            }
            else
            {
                Console.WriteLine("Стрелец");
            }
            break;

        case 12:
            if (day <= 21)
            {
                Console.WriteLine("Стрелец");
            }
            else
            {
                Console.WriteLine("Козерог");
            }
            break;
    }
    Console.WriteLine("Ваше животное по китайскому календарю: ");
    if (x == 0)
    {
        string return_animal = animal[x];
        Console.WriteLine(return_animal);
    }
    else
    {
        string return_animal = animal[x - 1];
        Console.WriteLine(return_animal);
    }
    Console.WriteLine("Ваша стихия: ");
    if (y > 4)
    {
        y = y / 2;
        string return_element = element[y];
        Console.WriteLine(return_element);
    }
    {
        Console.WriteLine("\n Попробуйте еще раз. \n Введите дату рождения в формате DD.MM.YYYY");
        return;
    }
}