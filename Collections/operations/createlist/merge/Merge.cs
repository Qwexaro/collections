namespace collections.operations.createlist.merge
{
    public class Merge
    {
        /// <summary>
        /// Метод для создания нового списка типа int на основе двух списков типа int
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns>Новый лист на основе двух листов</returns>
        /// <remarks><br>Author: Qwexaro</br></remarks>
        public static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            List<int> mergedList = new List<int>();

            for (int i = 0; i < list1.Count; i++) mergedList.Add(list1[i]);

            for (int i = 0; i < list2.Count; i++) mergedList.Add(list2[i]);

            return mergedList;
        }
    }
}
