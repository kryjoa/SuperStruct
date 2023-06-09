using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipBucket : MonoBehaviour
{
    public GameObject character_bucket;
    public GameObject mainCharacter;
    public GameObject Plane;
    public GameObject Bucket;
    public GameObject Axt;
    public Vector3 position;
    public GameObject AxtDude;
    public GameObject plankcaracter;
    public GameObject planks;

    void Start()
    {

    }
    void Update()
    {


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (mainCharacter.activeSelf)
                {
                    character_bucket.transform.position = mainCharacter.transform.position;
                    character_bucket.transform.rotation = mainCharacter.transform.rotation;
                }
                else if (AxtDude.activeSelf)
                {
                    character_bucket.transform.position = AxtDude.transform.position;
                    character_bucket.transform.rotation = AxtDude.transform.rotation;

                    Vector3 position = character_bucket.transform.position;
                    position.z = position.z + 1f;
                    Axt.transform.position = position;
                    Axt.SetActive(true);
                }
                else if (plankcaracter.activeSelf)
                {
                    character_bucket.transform.position = plankcaracter.transform.position;
                    character_bucket.transform.rotation = plankcaracter.transform.rotation;

                    Vector3 position = character_bucket.transform.position;
                    position.z = position.z + 1f;
                    planks.transform.position = position;
                    planks.SetActive(true);
                }


                mainCharacter.SetActive(false);
                AxtDude.SetActive(false);
                Bucket.SetActive(false);
                plankcaracter.SetActive(false);
                character_bucket.SetActive(true);



            }
        }
    }

}
