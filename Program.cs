internal class Program
{
    private static void Main(string[] args)
    {
        int []arr = { 1, 2, 4,2,5,2,6,8,2,5,3,6,2,1,7,9,5,3,4,4,5,5,};
        int x = int.Parse(Console.ReadLine());
        int count = 0;
        demSo(x, ref count, arr);
        Console.WriteLine(count);
    }
    public static void demSo(int x, ref int count, int []arr) {
        for(int i = 0; i < arr.Length; i++) {
            if(arr[i] == x) {
                count++;
            }
        }
    }
}