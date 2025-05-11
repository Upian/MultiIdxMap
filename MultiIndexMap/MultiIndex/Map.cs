namespace MultiIndex
{
	public class Map
	{
		private class Node<T_Key, T_Value>
		{
			public T_Key? Key { get; set; }
			public T_Value? Value { get; set; }
		}
	}
}
