using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipPlank : MonoBehaviour
{
    public GameObject PlankCharacterOn;
    public GameObject mainCharacter;
    public GameObject Plank;

    void Start()
    {
        PlankCharacterOn.SetActive(false);
    }
    void Update()
    {
        PlankCharacterOn.transform.position = mainCharacter.transform.position;
        PlankCharacterOn.transform.rotation = mainCharacter.transform.rotation;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Plank.SetActive(false);
                mainCharacter.SetActive(false);
                PlankCharacterOn.SetActive(true);
            }
        }
    }
}