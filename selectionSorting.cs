using System;

public static class selectionSorting
{

    public static void selectSorting<T>(T[] array) where T : IComparable
    {
        for (int i = 0; i < array.Length-1; i++) {

            int minIndex = i;
            T minValue = array[i];  



            for (int j = i +1; j < array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];    
                }
            }

            Swap(array, i, minIndex);   
        
        }


    //    public static int[] unsortedArray = {-11, 12, -42, 0, 1, 90, 68, 6, -9 };

}

    private static void Swap<T>(T[] array, int i, int minIndex) where T : IComparable
    {
        T temp =  array[i];
        array[i] = array[minIndex]; 
        array[minIndex] = temp;

    }
}
