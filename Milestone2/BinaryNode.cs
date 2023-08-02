using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class BinaryNode <T>
    {
        internal T Value { get; set; }
        internal BinaryNode<T> LeftChild, RightChild;

        internal BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
        internal void AddLeft(BinaryNode<T> child)  {   LeftChild = child; }

        internal void AddRight(BinaryNode<T> child) {  RightChild = child; }

        public override string ToString()
        {
            string result = string.Format("{0}:", Value);

            if (LeftChild == null)
                result += " null";
            else
                result += string.Format(" {0}", LeftChild.Value);

            if (RightChild == null)
                result += " null";
            else
                result += string.Format(" {0}:", RightChild.Value);

            return result;
        }

        public string ToString(string spaces)
        {
            string result = string.Format("{0}{1}:\n", spaces, Value);

            if ((LeftChild != null) || (RightChild != null))
            {
                if (LeftChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += LeftChild.ToString(spaces + "  ");

                if (RightChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += RightChild.ToString(spaces + "  ");
            }

            return result;
        }
    }
}
