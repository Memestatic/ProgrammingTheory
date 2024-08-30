using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Animal  // INHERITANCE
{
    private Rigidbody deerRB;
    void Start()
    {
        deerRB = GetComponent<Rigidbody>();

        animalType = "Deer";
        jumpForce = 5f;
    }

    public override string MakeSound()
    {
        return "roar";
    }

    public override void Jump()     // POLYMORPHISM
    {
        deerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
