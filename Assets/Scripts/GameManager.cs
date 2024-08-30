using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> animals;
    void Start()
    {
        for (int i = 0; i < animals.Count; i++)
        {
            animals[i].AnimalName = Menu.instance.names[i];
        }

        StartCoroutine(ChainJumping());
    }

    IEnumerator ChainJumping()
    {
        yield return new WaitForSeconds(2);
        animals[0].Jump();
        animals[0].SayHello();
        yield return new WaitForSeconds(2);
        animals[1].Jump();
        animals[1].SayHello();
        yield return new WaitForSeconds(2);
        animals[2].Jump();
        animals[2].SayHello();
    }
}
