namespace collections.src.main.cs.ru.topacademy.collections.operations.info
{
    public class Sum
    {
        /// <summary>
        /// Метод для подсчета суммы элементов списка типа int которые стоят на четных индексах. 
        /// <br><b>Нулевой индекс учитывается в качестве четного числа.</b></br>
        /// </summary>
        /// <param name="list"></param>
        /// <returns>информация о сумме элементов стоящих на четных индексах листа</returns>
        public static string SumIndexEvenNumbers(List<int> list)
        {
            int sumNumbersOnEvenIndex = 0;

            for (int i = 0; i <= list.Count - 1; i++) if (i % 2 == 0) sumNumbersOnEvenIndex += list[i];

            return $"\nСумма элементов под четными индексами: {sumNumbersOnEvenIndex}";
        }
    }
}