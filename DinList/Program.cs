using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinList
{
    public class Node
    {
        public char value;
        public Node adress;
        
        // Конструктор
        public Node(char c)
        {
            value = c;
            adress = null;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public class DinStack
    {
        Node top = null;

        public DinStack() { }
        
        public void Push(char c)
        {
            Node temp = new Node(c);
            temp.adress = top;
            top = temp;
        }

        public char Pop()
        {
            if (!IsEmpty())
            {
                char res = top.value;
                top = top.adress;
                return res;
            }
            return Convert.ToChar(0);
        }

        public bool IsEmpty()
        {
            return top == null;
        }
        public override string ToString()
        {
            string res = "";
            Node current = top;
            while(current != null)
            {
                res += current.ToString();
                current = current.adress;
            }

            return res;
        }
    }

    class Program
    {
        static string openBrackets = "({[<";
        static string closeBrackets = ")}]>";

        static bool IsPare(char close, char open)
        {
            var openIndex = openBrackets.IndexOf(open);
            char tempClose = closeBrackets[openIndex];
            return tempClose == close;
        }

        static void Main(string[] args)
        {            
            string brackets = "";
            DinStack stack = new DinStack();
            var answer = "Yes";
            foreach (var c in brackets)
            {
                if (openBrackets.IndexOf(c) >= 0)
                    stack.Push(c);
                else if (!stack.IsEmpty())
                {
                    char temp = stack.Pop();
                    if (!IsPare(c, temp)) { answer = "No"; break; }
                }
                else { answer = "No"; break; }
            }
            if (!stack.IsEmpty()) answer = "No";
            Console.WriteLine(answer);
        }
    }
}