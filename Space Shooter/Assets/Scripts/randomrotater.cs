using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomrotater : MonoBehaviour
{
    Rigidbody pyhsic;

    public int speed;
    void Start()
    {
        pyhsic = GetComponent<Rigidbody>();

        pyhsic.angularVelocity = Random.insideUnitSphere*speed;
    }


}
