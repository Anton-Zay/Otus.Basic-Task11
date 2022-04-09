using System;

namespace HomeWorkOfLesson11_v1
{
    public partial class Stack<String>
    {
        public int Size { get; private set; }

        public string Top
        {
            get { return current.Str; }
        }

        private StackItem<String> current;


        class StackItem<String>
        {
            public string Str { get; set; }
            public StackItem<String> Prev { get; set; }

            public StackItem(string str)
            {
                this.Str = str;
            }
        }

        public void Add(string str)
        {
            var newStackItem = new StackItem<String>(str);

            newStackItem.Prev = current;
            current = newStackItem;

            Size++;
        }

        public string Pop()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Стек пустой");
            }

            string str = default;

            str = current.Str;
            if (Size > 1)
                current = current.Prev;
            Size--;

            return str;
        }

        /*public static Stack<String> Concat(params Stack<String>[] stack)
        {
            var NewStack = new Stack<String>();

            foreach (var PartOfStack in stack)
            {
                while (PartOfStack.Size > 0)
                {
                    NewStack.Add(PartOfStack.Pop());
                }
            }

            return NewStack;
        }*/
    }
}