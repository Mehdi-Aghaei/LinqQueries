<Query Kind="Statements" />

var a =new Node(
new Node(null, new Node(null, null, 4), 2), 
new Node(new Node(null, null, 5), 
new Node(null, null, 6), 3), 
1);
TreeByLevels(a).Dump();
static List<int> TreeByLevels(Node node)
{
	List<int> results = new();
	Queue<Node> myQueue = new();
	if(node != null ){
		myQueue.Enqueue(node);
	}
	
	while(myQueue.Count() > 0){
		Node n = myQueue.Dequeue();
		if(n != null){
			results.Add(n.Value);
			myQueue.Enqueue(n.Left);
			myQueue.Enqueue(n.Right);
		}
	}

	return results;
}

public class Node
{
	public Node Left;
	public Node Right;
	public int Value;

	public Node(Node l, Node r, int v)
	{
		Left = l;
		Right = r;
		Value = v;
	}
}