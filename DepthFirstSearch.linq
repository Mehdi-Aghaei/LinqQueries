<Query Kind="Statements" />

public class Node {

	public Node Next { get; set; }
	public int Value { get; set; }
	
	public Node(int value , Node next = null)
	{
		this.Next = next;
		this.Value = value;
			
	}
}