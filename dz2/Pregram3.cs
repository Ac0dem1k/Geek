//������ 3: �������� ���������, ������� ��������� �� ���� �����
//������������ ���� ������, � ���������, �������� �� ���� ���� ��������
// 6 -> �� 
// 7 -> �� 
// 1 -> ��� 
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
	Console.WriteLine("��� �� ���� ������!");
	return false;
}

int weekDay = Prompt("������� ���� ������ >");
if (ValidateWeekday(weekDay))
{
	if (IsWeekkend(weekday))
	{
		Console.WriteLine("�������-�� ��������");
	}
	else
	{
		Console.WriteLine("�������� ���������");
	}
}