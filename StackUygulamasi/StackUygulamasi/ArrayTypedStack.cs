using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUygulamasi
{
    public class ArrayTypedStack
    {
        int MAX;
        int top;
        object[] stack;

        bool IsEmpty()
        {
            return (top < 0);
        }
        public ArrayTypedStack(int MAX)
        {
            stack = new object[MAX];
            this.MAX = MAX;
            top = -1;
        }
        public void Push(int data)
        {
            if (top < this.MAX)
            {
                stack[++top] = data;
            }
        }
        public object Pop()
        {
            object value = new object();

            if (top >= 0)
            {
                value = stack[top--];

            }
            return value;
        }
        public object Peek()
        {
            object value = new object();

            if (top >= 0)
                value = stack[top];

            return value;
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                MessageBox.Show("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    MessageBox.Show(stack[i].ToString());
                }
            }
        }
    }
}
