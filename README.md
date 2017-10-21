# AnimalTreeGame
##Create a game that asks questions and takes user y or n to guess an animal

I used a tutorial for a 20 questions game that I found at http://www.c-sharpcorner.com/uploadfile/4a950c/20-questions-guessing-game-using-binary-trees/

This uses the Node class to do most of the heavy lifting setting noNode and yesNode as the left/right properties of the node, and all the associated methods of traversal as well.

The UpdateTree method is what handles creating new nodes based on the user response to questions.
The query() method is used to traverse thru the tree with each yes answer.

If a node has two null refrences, the program is out of questions and is ready to make a guess.

The basic structure of the game is to start by asking a question and work down a tree with yes or no answers untill the program reaches a leaf node.  with a no answer, the program asks for a new question and answer and creates a new node in that spot.  
