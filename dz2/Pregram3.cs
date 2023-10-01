//Задача 3: Напишите программу, которая принимает на вход цифру
//обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да 
// 7 -> да 
// 1 -> нет 
int Prompt(string message)
{
	Console.Write(message);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

bool IsWeekkend(int weekDay)
{
	if (weekDay > 5)
	{
		return true;

	}
	return false;
}

bool ValidateWeekday(int number)
{ 
	if (number > 0 && number <= 7)
	{
		return true;
	}
	Console.WriteLine("Это не день недели!");
	return false;
}

int weekDay = Prompt("Введите день недели >");
if (ValidateWeekday(weekDay))
{
	if (IsWeekkend(weekday))
	{
		Console.WriteLine("Наконец-то выходной");
	}
	else
	{
		Console.WriteLine("Придется порабоать");
	}
}