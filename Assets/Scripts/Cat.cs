using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private Rigidbody catRB;
    void Start()
    {
        catRB = GetComponent<Rigidbody>();

        animalType = "Cat";
        jumpForce = 0.5f;
    }

    public override string MakeSound()
    {
        return "meow";
    }

    public override void Jump()
    {
        catRB.AddForce(new Vector3(0, 1, -0.5f) * jumpForce, ForceMode.Impulse);
    }
}
