namespace collections.operations.createlist
{
    public class Create
    {
        /// <summary>
        /// Метод для создания рандомного листа типа int. Первый аргумент принимает
        /// к-во элементов для листа, второй аргумент начало диапозона (для рандома), третий аргумент 
        /// конец диапозона (для рандома).
        /// </summary>
        /// <param name="countElements"></param>
        /// <param name="startRange"></param>
        /// <param name="endRange"></param>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        /// <returns>list</returns>
        public static List<int> CreateRandomIntList(int countElements, int startRange, int endRange)
        {
            Random random = new Random();

            List<int> list = new List<int>();

            for (int i = 0; i < countElements; i++) list.Add(random.Next(startRange, endRange));

            return list;
        }
    }
}