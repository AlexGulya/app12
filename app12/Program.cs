//int DoOperation(int op, int a, int b)
//{
//	switch (op)
//	{
//		case 0: return a + b;
//		case 1: return a - b;
//		case 2: return a * b;
//		default: return 0;

//	}
//}



//int result = DoOperation(1, 2, 3);
//Console.WriteLine(result);


int Operation(char op ,int a,  int b)
{
	switch (op)
	{
		case '+': return a + b;
		case '-': return a - b;
		case '*': return a * b;
		case '/': return a / b;

		default: return 0;

	}
}

Console.Write(" a: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" ");
char op2 = Convert.ToChar(Console.ReadLine());
Console.Write(" b: ");
int b2 = Convert.ToInt32(Console.ReadLine());
int result = Operation(op2, a2, b2);
Console.WriteLine(result);

