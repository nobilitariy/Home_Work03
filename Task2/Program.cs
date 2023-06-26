void GetSumNumerNum(){
    Console.WriteLine("Inter a integer number to determine the sum of the digits it is worth");
    int num = Convert.ToInt32(Console.ReadLine());
    int SumNum = 0;
    int resNum = 0;
    while(num > 0){
        SumNum += num % 10;
        num = num / 10;
        
    }
    Console.WriteLine(SumNum);

}

GetSumNumerNum();