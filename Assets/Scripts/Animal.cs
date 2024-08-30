using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalType;
    protected float jumpForce;

    private string animalName;
    public string AnimalName
    {
        get { return animalName; }
        set
        {
            if (value.Length < 3 || value.Length > 12)
            {
                animalName = "Invalid Name";
            }
            else
            {
                animalName = value;
            }
        }
    }

    public abstract string MakeSound();
    public void SayHello()
    {
        Debug.Log($"Hi, my name is {animalName}. I am {animalType} and I {MakeSound()}.");
    }

    public abstract void Jump();
}
