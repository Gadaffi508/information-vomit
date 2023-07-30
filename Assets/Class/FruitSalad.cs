using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Creating the fruit");
        Fruit myfruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myapple = new Apple();

        myfruit.SayHello();
        myfruit.Chop();

        myapple.SayHello();
        myapple.Chop();

        //<---------------New Constructor--------------->

        Debug.Log("Creating the fruit");
        myfruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myapple = new Apple("green");

        myfruit.SayHello();
        myfruit.Chop();

        myapple.SayHello();
        myapple.Chop();

        //<---------------Polymorphism--------------------->
        Debug.Log("<---------------------Polymorphism----------------->");

        Fruit myFruits = new Apple();
        myFruits.SayHello();
        myFruits.Chop();

        Apple myApple = (Apple)myFruits;

        myApple.SayHello();
        myApple.Chop();
    }
}
