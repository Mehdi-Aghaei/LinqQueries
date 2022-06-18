<Query Kind="Statements" />




var nodeA = new Node(1);
var nodeB = new Node(2);
var nodeC = new Node(3);
var nodeD = new Node(4);

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;
// A -> B -> C -> D -> null

static List<int> ShowLinkedList(Node linkedList){
	
	List<int> values = new();

	//Node current = linkedList;
	//while(current != null){
	//	values.Add(current.Value);
	//	current = current.Next;
	//}

	ValueGenerator(linkedList,values);
	return values;
}

static Node ValueGenerator(Node node,List<int> values)
{
	if (node is null)
	{
		return node;
	}
	values.Add(node.Value);
	return ValueGenerator(node.Next,values);
}
ShowLinkedList(nodeA).Dump();

//static ListNode insert(ListNode root, int item)
//{
//	ListNode temp = new ListNode();
//	ListNode ptr;
//	temp.val = item;
//	temp.next = null;
//
//	if (root == null)
//		root = temp;
//	else
//	{
//		ptr = root;
//		while (ptr.next != null)
//			ptr = ptr.next;
//		ptr.next = temp;
//	}
//	return root;
//}

public class Node
{
	public int Value { get; set; }
	public Node Next { get; set; }
	
	public Node(int val=0, Node next=null)
	{
		this.Value = val;
		this.Next = next;
	}
}

