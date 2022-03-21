using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
	public class Node
	{
		public Node Next;
		public Node Previous;		
		public int Value;

		public Node(int value)
		{
			Value = value;
		}
	}

	class DoubleLinkedList
    {
		public Node Head = null;
		public Node Tail = null;
		public Node Iterator = null;
		private int count = 0;

		public void SetIteratorHead()
		{
			Iterator = Head;
		}

		public void SetIteratorTail()
		{
			Iterator = Tail;
		}

		public int GetIteratorValue()
		{
			if (Iterator != null)
				return Iterator.Value;
			else
				return -1;
		}

		public void NextIterator()
		{
			if (Iterator.Next != null)
				Iterator = Iterator.Next;
		}

		public void PreviousIterator()
		{
			if (Iterator.Previous != null)
				Iterator = Iterator.Previous;
		}

		public int GetCount()
		{
			return count;
		}

		public string Print()
		{
			string result = "";
			Node current = Head;
			while (current != null)
			{
				result += current.Value + " ";
				current = current.Next;
			}

			return result;
		}

		private Node FindTail()
		{
			if (count == 0)
			{
				return null;
			}

			Node current = Head;
			while (current.Next != null)
			{
				current = current.Next;
			}

			return current;
		}

		public void PushBack(int item)
		{
			Node newNode = new Node(item);
			if (count == 0)
			{
				Head = newNode;
				Tail = newNode;
			}
			else
			{
				Tail.Next = newNode;
				newNode.Previous = Tail;
				Tail = newNode;
			}

			count++;
		}


	}
}
