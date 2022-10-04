DoOperation(Operation.Subtrack, 10, 5);
DoOperation(Operation.Add, 30, 40);
DoOperation(Operation.Multiply, 10, 10);
DoOperation(Operation.Divide, 100, 2);


void DoOperation(Operation operation, int x, int y)
{
    int result = operation switch
    {
        Operation.Add => x + y,
        Operation.Subtrack => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
  
}









enum Operation
{
    Add,
    Subtrack,
    Multiply,
    Divide
}