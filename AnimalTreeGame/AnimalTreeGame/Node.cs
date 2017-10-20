using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AnimalTreeGame
{
    class Node
    {
        string message;
        Node noNode;
        Node yesNode;
        /**
         * Constructor for the nodes: This class holds an String representing 
         * an object if the noNode and yesNode are null and a question if the
         * yesNode and noNode point to a BTNode.
         */
        public Node(string nodeMessage)
        {
            message = nodeMessage;
            noNode = null;
            yesNode = null;
        }
        public void Query()
        {
            if (this.IsQuestion())
            {
                Console.WriteLine(this.message);
                Console.Write("Enter 'y' for yes and 'n' for no: ");
                char input = GetYesOrNo(); //y or n
                if (input == 'y')
                    yesNode.Query();
                else
                    noNode.Query();
            }
            else
                this.OnQueryObject();
        }
        public void OnQueryObject()
        {
            Console.WriteLine("Are you thinking of a(n) " + this.message + "?");
            Console.Write("Enter 'y' for yes and 'n' for no: ");
            char input = GetYesOrNo(); //y or n
            if (input == 'y')
                Console.Write("The Computer Wins\n");
            else
                UpdateTree();
        }
        private void UpdateTree()
        {
            Console.Write("You win! What were you thinking of?");
            string userObject = Console.ReadLine();
            Console.Write("Please enter a question to distinguish a(n) "
                + this.message + " from " + userObject + ": ");
            string userQuestion = Console.ReadLine();
            Console.Write("If you were thinking of a(n) " + userObject
                + ", what would the answer to that question be?");
            char input = GetYesOrNo(); //y or n
            if (input == 'y')
            {
                this.noNode = new Node(this.message);
                this.yesNode = new Node(userObject);
            }
            else
            {
                this.yesNode = new Node(this.message);
                this.noNode = new Node(userObject);
            }
            Console.Write("Thank you my knowledge has been increased");
            this.SetMessage(userQuestion);
        }
        public bool IsQuestion()
        {
            if (noNode == null && yesNode == null)
                return false;
            else
                return true;
        }
        /**
         * Asks a user for yes or no and keeps prompting them until the key
         * Y,y,N,or n is entered
         */
        private char GetYesOrNo()
        {
            char inputCharacter = ' ';
            while (inputCharacter != 'y' && inputCharacter != 'n')
            {
                inputCharacter = Console.ReadLine().ElementAt(0);
                inputCharacter = Char.ToLower(inputCharacter);
            }
            return inputCharacter;
        }
        //Mutator Methods
        public void SetMessage(string nodeMessage)
        {
            message = nodeMessage;
        }
        public string GetMessage()
        {
            return message;
        }
        public void SetNoNode(Node node)
        {
            noNode = node;
        }
        public Node GetNoNode()
        {
            return noNode;
        }
        public void SetYesNode(Node node)
        {
            yesNode = node;
        }
        public Node GetYesNode()
        {
            return yesNode;
        }
    }
}
