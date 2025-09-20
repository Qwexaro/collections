namespace collections.operations.remove
{
    public class Remove
    {
        /// <summary>
        /// Метод для удаления четных чисел из списка типа int.
        /// </summary>
        /// <param name="list"></param>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        public static void RemoveEvenNumbersFromList(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--) { if (list[i] % 2 == 0) list.RemoveAt(i); }
        }
    }
}