using System;
using System.Collections.Generic;
using System.Linq;

namespace mustafabukulmez_com_dersler._047_Dizideki_Bir_Elemanın_Indeksini_Bulmak
{
    // extension, bir genişletme sınıfıdır. sık sık kullandığımız *.ToString() gibi bir kullanım kazandırır.
    public static class MyExtensions
    {

        /// <summary>
        /// Array içerisinde -IndexOf- metodu arama yapan ve index numarasını dönen metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">İçinde arama yapılacak array</param>
        /// <param name="item">Aranacak eleman</param>
        /// <returns>Aranacak elemanın array içerisindeki index numarası</returns>
        public static int findIndex_IndexOf<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }

        /// <summary>
        /// Array içerisinde -FindIndex- metodu arama yapan ve index numarasını dönen metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">İçinde arama yapılacak array</param>
        /// <param name="item">Aranacak eleman</param>
        /// <returns>Aranacak elemanın array içerisindeki index numarası</returns>
        public static int findIndex_FindIndex<T>(this T[] array, T item)
        {
            return Array.FindIndex(array, val => val.Equals(item));
        }

        /// <summary>
        /// Array içerisinde -Enumrable ve First- metodu arama yapan ve index numarasını dönen metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">İçinde arama yapılacak array</param>
        /// <param name="item">Aranacak eleman</param>
        /// <returns>Aranacak elemanın array içerisindeki index numarası</returns>
        public static int findIndex_EnumrableFirst<T>(this T[] array, T item)
        {
            try
            {
                return array
                    .Select((element, index) => new KeyValuePair<T, int>(element, index))
                    .First(x => x.Key.Equals(item)).Value;
            }
            catch (InvalidOperationException)
            {
                return -1;
            }
        }

        /// <summary>
        /// Array içerisinde -Enumrable ve FirstOrDefault- metodu arama yapan ve index numarasını dönen metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">İçinde arama yapılacak array</param>
        /// <param name="item">Aranacak eleman</param>
        /// <returns>Aranacak elemanın array içerisindeki index numarası</returns>
        public static int findIndex_EnumrableFirstOrDefault<T>(this T[] array, T item)
        {
            // FirstOrDefault() metodunu,  Try catch ve First(): bloğu yerine kullanabilirsiniz.
            return array
                .Select((element, index) => new { element, index }) 
                .FirstOrDefault(x => x.element.Equals(item))?.index ?? -1;
        }

        /// <summary>
        /// Array içerisinde -Performing Linear Search- yöntemi arama yapan ve index numarasını dönen metot.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">İçinde arama yapılacak array</param>
        /// <param name="item">Aranacak eleman</param>
        /// <returns>Aranacak elemanın array içerisindeki index numarası</returns>
        public static int findIndex_PerformingLinearSearch<T>(this T[] array, T item)
        {
            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < array.Length; i++)
            {
                if (comparer.Equals(array[i], item))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
