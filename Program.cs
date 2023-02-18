// See https://aka.ms/new-console-template for more information

var sort = new dotnet.BubleSort();

var arr = new int[]{1,3,4,6,5,2,7};

arr = sort.Sort(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}