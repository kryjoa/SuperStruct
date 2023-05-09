using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPickup : MonoBehaviour
{
    public GameObject WaterBucketCharacter;
    public GameObject BucketCharacter;
    public GameObject BarrelWater;
    public bool check = false;


    void Update()
    {
        Water();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            check = false;
        }
    }

    private void Water()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E))
            {
                WaterBucketCharacter.transform.position = BucketCharacter.transform.position;
                WaterBucketCharacter.transform.rotation = BucketCharacter.transform.rotation;
                BucketCharacter.SetActive(false);
                WaterBucketCharacter.SetActive(true);
                check = false;
            }
        }
    }
}
