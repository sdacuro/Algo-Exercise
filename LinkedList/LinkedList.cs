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