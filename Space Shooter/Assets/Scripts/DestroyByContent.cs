using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContent : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerexplosion;




    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundry") 
        {
            return;
        }
        Instantiate(explosion,transform.position,transform.rotation);
        if (other.tag=="Player")
        {
            Instantiate(playerexplosion,other.transform.position,other.transform.rotation);
        }

      Destroy(other.gameObject);
      Destroy(gameObject);
    }


}
