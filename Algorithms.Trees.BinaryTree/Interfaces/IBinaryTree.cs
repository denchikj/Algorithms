using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees.BinaryTree.Interfaces
{
    public interface IBinaryTree<T>
    {
        T Data { get; }
        IBinaryTree<T> Right { get; }
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Parent { get; set; }
        bool IsEmpty { get; }
        bool HasLeft { get; }
        bool HasRight { get; }
        void AddRight(IBinaryTree<T> right);
        void AddLeft(IBinaryTree<T> left);
        bool IsInternal(IBinaryTree<T> binaryTree);
        bool IsExternal(IBinaryTree<T> binaryTree);
        int Height(IBinaryTree<T> binaryTree);
        int Depth(IBinaryTree<T> binaryTree);
    }
}
