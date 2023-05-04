using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject character_AxeOn;
    public GameObject mainCharacter;
    public GameObject Axe;

    void Start()
    {
        character_AxeOn.SetActive(false);
    }
    void Update()
    {
        character_AxeOn.transform.position = mainCharacter.transform.position;
        character_AxeOn.transform.rotation = mainCharacter.transform.rotation;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Axe.SetActive(false);
                mainCharacter.SetActive(false);
                character_AxeOn.SetActive(true);
            }
        }
    }
}
