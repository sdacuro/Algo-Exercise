using System;

namespace Algo.LinkedList
{
    public class LinkedList
    {
        private class Node 
        {
            public int Value;
            public Node Next;
            public Node() {}
            public Node(int item)
            {
                this.Value = item;
            }
        }

        private Node _first;
        private Node _last;
        private int _count;

        public void AddFirst(int value) 
        {
            var node = new Node(value);
            if (IsEmpty())
                _first = _last = node;
            else
            {
                node.Next = _first;
                _first = node ;
            }
            _count++;
        }
        public void AddLast(int value)
        {
            var node = new Node(value);
            if (IsEmpty())
                _first = _last = node;
            else
            {
                _last.Next = node;
                _last = node;
            }
            _count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty()) throw new Exception("No item to remove!");

            if (_first == _last) 
                _first = _last = null;
            else 
                _first = _first.Next;
            
            _count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty()) throw new Exception("No item to remove!");

            if (_first == _last) 
            {
                _first = _last = null;
            }
            else
            {
                var previous = GetPreviousNode(_last);
                _last = previous;
                if (previous != null) _last.Next = null;
            }
            _count--;
        }

        public bool Contains(int item)
        {
            return (IndexOf(item) != -1);
        }

        public int IndexOf(int item)
        {
            int counter = 0;
            var currentNode = _first;
            while (currentNode != null)
            {
                if (currentNode.Value == item)
                    return counter;
                currentNode = currentNode.Next;
                counter++;
            }
            return -1;
        }

        public int Size() 
        {
            return _count;
        }
        private bool IsEmpty()
        {
            return (_first == null);
        }

        public int[] ToArray() 
        {
            var array = new int[Size()]; 
            var currentNode = _first;
            var index = 0;

            for(int i = 0; i < Size(); i++)
            {
                array[index++] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return array;
        }

        public void Reverse()
        {
            /*  method 1
            var linkedList = new LinkedList();

            var currentNode = _first;
            while(currentNode != null)
            {
                linkedList.AddFirst(currentNode.Value);
                currentNode = currentNode.Next;
            }

            _first = linkedList._first;
            _last = linkedList._last;

            */

            // method 2
            if (IsEmpty()) return;

            Node reverseNode = null;
            var currentNode = _first;
            while (currentNode != null)
            {
                var node = new Node(currentNode.Value);
                if (reverseNode == null) 
                    reverseNode = node;
                else
                {
                    node.Next = reverseNode;
                    reverseNode = node;
                }
                currentNode = currentNode.Next;
            }

            _last = new Node(_first.Value);
            _first = reverseNode;
        }

        public int GetValueByIndex(int index)
        {
            var currentNode = _first;
            for(int i = 1; i < index; i++)
                currentNode = currentNode.Next;
            return currentNode.Value;
        }
        private Node GetPreviousNode(Node node) 
        {
            var currentNode = _first;
            while (currentNode != null)
            {
                if (currentNode.Next == node) return currentNode;
                currentNode = currentNode.Next;
            }
            return null;
        }
    }


}