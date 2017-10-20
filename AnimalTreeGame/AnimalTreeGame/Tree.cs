using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AnimalTreeGame
{
    class Tree
    {
        Node rootNode;
        public Tree(string question, string yesGuess, string noGuess)
        {
            rootNode = new Node(question);
            rootNode.SetYesNode(new Node(yesGuess));
            rootNode.SetNoNode(new Node(noGuess));
        }
        public void Query()
        {
            rootNode.Query();
        }
    }
}
