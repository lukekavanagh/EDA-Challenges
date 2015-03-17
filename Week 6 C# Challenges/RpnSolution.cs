// Pseudo-code
 * DEFINE public method Evaluate returning integer, accepting parameter expression of type string
 *
 *     READ tokens from string one by one from left to right
 *         IF token is a number, store on stack
 *         IF token is an operator, take the first two numbers on stack and apply operator to them
 *             Put result of operation back in stack
 *         Continue until no more tokens
 *     RETURN last number on stack
 *
 * INPUT              STACK
 * 1 1 + 2 +
 * 1 + 2 +            1
 * + 2 +              1 1
 * 2 +                2
 * +                  2 2
 *                    4
 */


// Initial solution

// Refactored solution
using System;
using System.Collections.Generic;

namespace ReversePolishNotationCalculater
{
    public class RPNCalculator //Create RPN Evaluator class 
    {
        public int Evaluate(string expression) // create instance method evaluate which takes an string RPN expression as input
        {
            Stack<int> stack = new Stack<int>(); // create a new "last in/first out" stack, because we are going
            // to be pushing (adding) numbers to the stack and popping (removing) numbers to the stack  using Reverse Polish Notation.


            String[] tokens = expression.Split(' ') // create string array called tokens and split the input expression string with a space ' '
            for (int i = 0; i < tokens.Length; i++) // create for loop to iterate through string array tokens.length
            {
                int n;   // set an integer n, and at each iteration. use the tryparse method to change the string to a number,
                // on each position of tokens in the array, outputing the integer n.
                // 
                if (int.TryParse(tokens[i], out n) == true)
                {
                    // put number on stack
                    stack.Push(n);
                }
                else
                {
                    // else we know that the token must be an operator, so remove the integers
                    int b = stack.Pop();
                    int a = stack.Pop();

                    // op can be +, -, or *
                    switch (tokens[i]) // use switch statement at each iteration of tokensto define
                     // the behaviour for integers and the operands +, - and *
                    {
                        case "+":
                            stack.Push(a + b);
                            break;

                        case "-":
                            stack.Push(a - b);
                            break;

                        default:
                            stack.Push(a * b);
                            break;
                    }
                }
            }

            return stack.Pop(); // remove from stack
        }
    }
}
// Reflections
//  * Gained greater understanding of LIFO collections (stack).
// * Cemented knowledge of tryparse method
// * General observation is that You can do things generally by using a for loop/foreach  to engineer action,
// and using an if statement to define conditions within the for loop,
// defining different actions if the conditions are met.
// *RPN messes with my head, please don't set any more RPN challenges!