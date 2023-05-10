using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipPlank : MonoBehaviour
{
    public GameObject PlankCharacterOn;
    public GameObject MainCharacter;
    public GameObject Planks;

    void Start()
    {
        PlankCharacterOn.SetActive(false);
    }
    void Update()
    {
        if (MainCharacter.activeSelf)
        {
            PlankCharacterOn.transform.position = MainCharacter.transform.position;
            PlankCharacterOn.transform.rotation = MainCharacter.transform.rotation;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                
                MainCharacter.SetActive(false);
                PlankCharacterOn.SetActive(true);
                Planks.SetActive(false);


            }
        }
    }
}