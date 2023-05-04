using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;


public class ProduceWater : MonoBehaviour
{
    public GameObject BucketCharacter;
    public GameObject AxeONCharacter;
    public float radius = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }

    public void Spawn()
    {
        float distance = Vector3.Distance(transform.position, BucketCharacter.transform.position);
        if (gameObject == BucketCharacter.activeInHierarchy)
        {
            if (distance <= radius)
            {
                BucketCharacter.transform.position = AxeONCharacter.transform.position;
                BucketCharacter.transform.rotation = AxeONCharacter.transform.rotation;
                BucketCharacter.SetActive(false);
                AxeONCharacter.SetActive(true);
            }
        }
    }
}
