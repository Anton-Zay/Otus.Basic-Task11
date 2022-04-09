using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOfLesson11_v1
{
    public static class StackExtensions
    {
        public static Stack<string> Merge(this Stack<String> stack, Stack<String> s2)
        {
            while (s2.Size > 0)

            {
                stack.Add(s2.Pop());
            }

            return stack;
        }
        
        public static Stack<string> Concat(this Stack<String> stack, params Stack<String>[] stack1)
        {
            var NewStack = new Stack<String>();

            while (stack.Size > 0)

            {
                NewStack.Add(stack.Pop());
            }

            foreach (var PartOfStack in stack1)
            {
                while (PartOfStack.Size > 0)
                {
                    NewStack.Add(PartOfStack.Pop());
                }
            }

            return NewStack;
        }
    }
}