/* ������ 29 �������� ���������, ������� ����� ������ �� N ��������� � ������� �� �� �����.
5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33] */

int lenArray = ReadInt("������� ������ �������: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
	randomArray[i] = new Random().Next(1, 9);
	Console.Write(randomArray[i] + " ");
}


// ������� �����
int ReadInt(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}