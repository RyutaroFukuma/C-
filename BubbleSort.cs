///<summary>
///バブルソート
///M</summary>
/// <param name="a">対象の配列</param>

public static void BubbleSort<T>(T[] a)
  where T : IComparable<T>
{
  int n = a.length;
  for (int i = 0; i < n - 1; i++)
    for (int j = n - 1; j > i; j--)
      if (a[j].CompareTo(a[j - 1]) < 0)
	swap(ref a[j], ref a[j - 1]);
}
