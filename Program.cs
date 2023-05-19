class Program
{
    static void Main()
    {
        Console.Write("ช่วงถนน : ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("ขอบเขต : ");
        int road = int.Parse(Console.ReadLine());

        int Newroad = road+(road+1);

        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("จำนวนลูกค้าเขตที่ " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        int maxSumIndex = 0;

        for (int i = 0; i < count - Newroad + 1; i++)
        {
            int sum = 0;
            for (int j = 0; j < Newroad; j++)
            {
                sum += numbers[i + j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumIndex = i;
            }
        }

        Console.Write("จำนวนลูกค้ารวมสูงสุด : ");
        
        Console.WriteLine(maxSum);
    }
}