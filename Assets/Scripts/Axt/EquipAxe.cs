using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject character_AxeOn;
    public GameObject mainCharacter;
    public GameObject player_bucket;
    public GameObject Axe;
    public Vector3 position;
    public GameObject bucket;
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
                    character_AxeOn.transform.position = mainCharacter.transform.position;
                    character_AxeOn.transform.rotation = mainCharacter.transform.rotation;
                }
                else if (player_bucket.activeSelf)
                {
                    character_AxeOn.transform.position = player_bucket.transform.position;
                    character_AxeOn.transform.rotation = player_bucket.transform.rotation;
                    Vector3 position = character_AxeOn.transform.position;
                    position.z = position.z + 1f;
                    bucket.transform.position = position;
                    bucket.SetActive(true);
                }

                else if (plankcaracter.activeSelf)
                {
                    character_AxeOn.transform.position = plankcaracter.transform.position;
                    character_AxeOn.transform.rotation = plankcaracter.transform.rotation;
                    Vector3 position = character_AxeOn.transform.position;
                    position.z = position.z + 1f;
                    planks.transform.position = position;
                    planks.SetActive(true);
                }


                mainCharacter.SetActive(false);
                player_bucket.SetActive(false);
                plankcaracter.SetActive(false);
                character_AxeOn.SetActive(true);


                Axe.SetActive(false);
            }
        }
    }

}
