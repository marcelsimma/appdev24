class Do
{
    public static void PrintDoSmth(string[] args)
    {
     DoSmth();
    }
    public static void DoSmth()
    {
          for (int i = 0; i <= 10; i++){
            int result = i * 2;
            Console.WriteLine($"{i} * 2 = {result}");
        }
    }
}

