using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Animal
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

    public override void Jump()
    {
        deerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
