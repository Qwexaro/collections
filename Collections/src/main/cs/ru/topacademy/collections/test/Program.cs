using collections.src.main.cs.ru.topacademy.collections.custome;
using collections.src.main.cs.ru.topacademy.collections.operations.createlist;
using collections.src.main.cs.ru.topacademy.collections.operations.createlist.merge;
using collections.src.main.cs.ru.topacademy.collections.operations.info;
using collections.src.main.cs.ru.topacademy.collections.operations.remove;

namespace collections.src.main.cs.ru.topacademy.collections.test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1:\n");

            List<int> list = Create.CreateRandomIntList(15, 0, 100);

            Console.Write("Лист до удаления элементов: ");

            Print.WriteList(list);

            Remove.RemoveEvenNumbersFromList(list);

            Console.Write("\nЛист после удаления элементов: ");

            Print.WriteList(list);

            Print.Line();

            Console.WriteLine("Задание 2:\n");

            List<int> list2 = Create.CreateRandomIntList(20, -50, 50);

            Console.Write("Сам лист: "); Print.WriteList(list2);
            
            Console.Write(Status.StatusNumbersFromList(list2));
            
            Print.Line();

            Console.WriteLine("Задание 3:\n");

            List<int> list3 = Create.CreateRandomIntList(10, 1, 10);

            Console.Write("Сам лист: "); Print.WriteList(list3);

            Console.Write(Sum.SumIndexEvenNumbers(list3));

            Print.Line();
            
            Console.WriteLine("Задание 4:\n");
            
            List<int> list1ForMergeTask4 = Create.CreateRandomIntList(5, 1, 20);
            List<int> list2ForMergeTask4 = Create.CreateRandomIntList(5, 1, 20);

            Console.Write("Лист1: "); Print.WriteList(list1ForMergeTask4);
            Console.Write("Лист2: "); Print.WriteList(list2ForMergeTask4);

            Console.Write("Объединенный лист: "); Print.WriteList(Merge.MergeLists(list1ForMergeTask4, list2ForMergeTask4));

            Print.Line();
            
            Console.WriteLine("Задание 5:\n");
            
            List<int> list5 = Create.CreateRandomIntList(20, 1, 20);

            Console.Write("Лист: "); Print.WriteList(list5);

            Console.WriteLine(Max.FindMaxNumberFromList(list5));
        }
    }
}