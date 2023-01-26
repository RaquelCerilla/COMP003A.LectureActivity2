/*
 * Author: Raquel Cerilla
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, Math. and Console properties
 * Refrence: The C# Player's Guide (4e) by RB Whitaker
 */

using System.Security.Cryptography.X509Certificates;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        /* working with variables */
        // the following code shows all three primary variable-related activites:
        string username; // declaring a veriable (1 of 3)
        Console.WriteLine("What is your name?"); // request for user input
        username = Console.Readline(); // assigning a value to a veriable (2 of 3) 