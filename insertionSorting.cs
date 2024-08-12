using System; 
public static class insertionSorting
{
	public static void insertSort<T>(T[] array) where T : IComparable
	{
		for (int i = 0; i < array.Length; i++)
		{
            T minValue = array[i];
            T nxtValue = array[i + 1];

            if (minValue.CompareTo(nxtValue) < 0) {
                
                selectionSorting.Swap(array, i, i + 1);
            }
            






        }
    }
}
