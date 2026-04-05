using System;
using System.Drawing;
using System.Security.AccessControl;

namespace G_NET_29_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Part 01 : 
        #region Q1 :
        //class: Reference Type,,is a blueprint.
        //struct: is a lightweight Value Type.
        //EX:
        // Struct Behavior
        //Point p1;
        //p1.X = 10;
        //Point p2 = p1;
        //p2.X = 99;        //p1.X=10

        //// Class Behavior 
        //Student s1 = new Student();
        //s1.Age = 20;
        //Student s2 = s1; 
        //s2.Age = 30; //s1.Age = 30;
        #endregion

        #region Q2:
        // Private: accessible within the class at theye registered,
        // and can not be accessed from outside.This is the default setting for class members.
        // Pubic:The member have access to any location within the application or other projects they view.
        //Ex:
        //class User
        //{
        //    public string userName; //Any part of the code can be accessed and modified.
        //    private string password; // It cannot be viewed or modified from outside the class for protection.
        //    public void SetPassword(string p)
        //    {
        //        password = p;
        //    }
        //}
        #endregion
    }
    }
}
