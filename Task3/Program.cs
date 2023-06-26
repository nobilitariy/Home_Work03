void GetMass(){
    int[] mass = new int[8];
    for(int i = 0; i < 8 ; i++){
        int num = new Random().Next(0, 100);
        mass[i] = num;
    }
    Console.Write("Массив из 8 рандомных элементов: ");
    Console.WriteLine(string.Join(", ", mass));      
}
 GetMass();