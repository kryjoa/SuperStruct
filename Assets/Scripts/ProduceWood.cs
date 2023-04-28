using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class ProduceWood : MonoBehaviour
{
    public GameObject Palette;
    public GameObject Holz;
    public GameObject character_AxeOn;
    public float radius = 5f;
    public GameObject MainCharacter;
    public GameObject BucketCharacter;

    // Start is called before the first frame update
    void Start()
    {
        Holz.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject != MainCharacter.activeInHierarchy && gameObject != BucketCharacter.activeInHierarchy)
        {
            float distance = Vector3.Distance(transform.position, other.transform.position);
            if (distance <= radius)
            {
                InvokeRepeating("Spawn", 0f, 5f);
            }
        }
    }
    
    public void Spawn()
    {
        
        Holz.SetActive(true);
        Instantiate(Holz, Holz.transform.position, Holz.transform.rotation);

    }
}
