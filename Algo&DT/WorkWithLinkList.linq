<Query Kind="Statements" />


var nodeA = new Node(9);

var nodeb = new Node(1);
var nodec = new Node(9);
var noded = new Node(9);

var nodeD = new Node(9);
var nodeE = new Node(9);
var nodeF = new Node(9);

var nodeg = new Node(9);
var nodeh = new Node(9);
var nodei = new Node(9);

var nodej = new Node(9);




nodeb.Next = nodec;
noded.Next = nodeE;
nodeE.Next = nodeF;
nodeF.Next = nodeg;
nodeg.Next = nodeh;
nodeh.Next = nodei;
nodei.Next = nodej;

AddTwoNumbers(nodeA,nodeb).Dump();

static Node AddTwoNumbers(Node l1, Node l2)
{
	var numberOneHolder = new List<int>();
	var numberTwoHolder = new List<int>();
	
	Numbers(l1,numberOneHolder);
	Numbers(l2,numberTwoHolder);
	
	var number1 = string.Join("",numberOneHolder);
	var number2 = string.Join("",numberTwoHolder);
	
	number1 = string.Join("",number1.Reverse().ToArray());
	number2 = string.Join("",number2.Reverse().ToArray());
	
	int sum = int.Parse(number1)+  int.Parse(number2);
	
	var result = string.Join("",sum.ToString().Reverse().ToArray());
	
	Node head = add(result[0]);
	Node curr = head;
	
	for (int i = 1; i < result.Length; i++)
	{
		curr.Next = add(result[i]);
		curr = curr.Next;
	}

	return head;
}

static Node add(char data)
{
	Node newnode = new Node();
	newnode.Value = int.Parse(data.ToString());
	newnode.Next = null;
	return newnode;
}

static void Numbers(Node node, List<int> numbers)
{
	Node current = node;
	while(current != null){
		numbers.Add(current.Value);
		current = current.Next;
	}
}

public class Node
{
	public int Value { get; set; }
	public Node Next { get; set; }

	public Node(int val = 0, Node next = null)
	{
		this.Value = val;
		this.Next = next;
	}
}
