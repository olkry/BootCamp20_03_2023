//using static ArreyCreator;


//Можно не писать верхнюю команду, но надо перед Create, указать ArreyCreator.
//int[] array = ArreyCreator.Create(10);
//В ArreyCreator добавили this и можем записать так:
//int[] array = 10.Create();


using static ArreyCreator;
using static ArreyMath;
using System.Diagnostics;

int[] array = 1000000.Create()
                .Fill(1, 10);
//array.ConvertToStringAndPrintTerminal();

// // Для метода BadGetSum
// int max = array.BadGetSum();
// Console.WriteLine(max);

//Для метода GoodGetSum, сравним его с BadGetSum


int m;

m = 100000;
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");


sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");



//Console.WriteLine(array.ConvertToString());
