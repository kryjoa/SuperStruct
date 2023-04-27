using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipBucket : MonoBehaviour
{
    public GameObject character_BucketOn;
    public GameObject controllerOff;
    public GameObject character_Axe;
    //public GameObject Maincharacter;
    //public Vector3 position;

    void Start()
    {
        character_BucketOn.SetActive(false);
    }
    //void Update()
    //{
    //    character_AxeOn.position = transform.position;
    //    transform.position = Maincharacter.position;
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(character_Axe.SetActive(true))
            {
                character_BucketOn
            }
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                controllerOff.SetActive(false);
                character_BucketOn.SetActive(true);
            }
        }
    }
}