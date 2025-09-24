namespace collections.src.main.cs.ru.topacademy.collections.custome
{
    public class Print
    {
        /// <summary>
        /// Метод для распечатывания листа состоящего из элементов типа int
        /// </summary>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        /// <param name="list"></param>
        public static void WriteList(List<int> list) { foreach (int i in list) Console.Write($"{i} "); Console.WriteLine(); }
        /// <summary>
        /// Метод для печати линии (может быть полезна для печати границы заданий)
        /// <remarks><br>Author: Qwexaro</br></remarks>
        /// </summary>
        public static void Line() { Console.WriteLine(); for(int i = 0; i < 100; i++) Console.Write("-"); Console.WriteLine(); }
    }
}