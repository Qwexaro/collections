namespace collections.src.main.cs.ru.topacademy.collections.operations.info
{
    public class Max
    {
        /// <summary>
        /// Метод для поиска максимального элемента из листа типа int.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>Информация о максимальном элементе из листа</returns>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        public static string FindMaxNumberFromList(List<int> list)
        {
            int maxNumber = 0;

            foreach (int i in list) { if (i >= maxNumber) maxNumber = i; }

            return $"\nМаксимальное число из списка: {maxNumber}";
        }
    }
}