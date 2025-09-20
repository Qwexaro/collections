namespace collections.operations.info
{
    public class Status
    {
        /// <summary>
        /// Метод для подсчета к-ва отрицательных, положительных чисел и нулей из листа типа int.
        /// </summary>
        /// <param name="list"></param>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        /// <returns>Информация о содержимом листа (к-во отрицательных, положительных чисел и нулей)</returns>
        public static string StatusNumbersFromList(List<int> list)
        {
            int negNumber = 0, postiveNumber = 0, zeroNumbers = 0;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] > 0) postiveNumber++; 
                
                else if (list[i] < 0) negNumber++;
                
                else zeroNumbers++;
            }

            return $"Отрицательных чисел: {negNumber}, положительных: {postiveNumber}, нулей: {zeroNumbers}";
        }
    }
}