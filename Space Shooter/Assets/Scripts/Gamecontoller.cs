using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontoller : MonoBehaviour
{
    public GameObject hazard;
    void SpawnValues()
    {
        Vector3 spawnPosition=new Vector3(Random.Range(20,26),0,12);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(hazard,spawnPosition, spawnRotation);
    }
    void Start()
    {
        SpawnValues();
    }

    
}
