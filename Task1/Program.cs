void Print(string text){
    Console.WriteLine(text);
}

int Exponentiation(int FirstNum, int SecondNum){
    int degree = (int)Math.Pow(FirstNum, SecondNum);
    return degree;
}

Print("Inter two number (fisrt number, second degree), to exponentiate: ");
int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation(x, y);
Print($"{result}");




