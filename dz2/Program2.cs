// ������ 2: �������� ���������, ������� ������� ������ ����� ���������
// ����� ��� ��������, ��� ������� ����� ���. 
// 645 ->
// 78 -> ������� ����� ���
// 32679 -> 6 

int Prompt(string message)
{
	Console.Write(message);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;

}

int GetThirdRank(int number)
{
	while (number > 999)
	{
		number /= 10;
	}
	return number % 10;
}

bool ValidateNumber(int number)
{
	if (number < 100)
	{
		Console.WriteLine("������� ����� ���");
		return false;
	}
	return true;
}


int number = Prompt("������� ����� >");
if (ValidateNumber(number))
{
	Console.WriteLine(GetThirdRank(number));
}



