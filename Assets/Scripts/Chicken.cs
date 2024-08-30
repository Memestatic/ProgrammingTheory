using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    private Rigidbody chickenRB;

    void Start()
    {
        chickenRB = GetComponent<Rigidbody>();

        animalType = "Chicken";
        jumpForce = 0.5f;
    }

    public override string MakeSound()
    {
        return "cluck";
    }

    public override void Jump()
    {
        chickenRB.AddForce(new Vector3(0, 1, 0.5f) * jumpForce, ForceMode.Impulse);
    }
}
