using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class oyuncukontroller : MonoBehaviour
{
    Rigidbody physic;

    [SerializeField] int hýz;
    [SerializeField] int tilt;
    [SerializeField] float nextFire;
    [SerializeField] float FireRate;

    public Boundary boundary;
    public GameObject shot;
    public GameObject shotspawn;




    void Start()
    {
     physic=GetComponent<Rigidbody>();   
    }

    void Update()
    {
        Debug.Log(Time.time);
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire= Time.time + FireRate;
            Instantiate(shot, shotspawn.transform.position, shotspawn.transform.rotation);
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement=new Vector3 (moveHorizontal,0,moveVertical);
        physic.velocity = movement * hýz ;

        Vector3 position = new Vector3(
            Mathf.Clamp(physic.position.x, boundary.xMin,boundary.xMax),
            0,
            Mathf.Clamp(physic.position.z, boundary.zMin, boundary.zMax)
            );

        physic.position=position;

        physic.rotation = Quaternion.Euler( 0, 0, physic.velocity.x * tilt);

    }
}
