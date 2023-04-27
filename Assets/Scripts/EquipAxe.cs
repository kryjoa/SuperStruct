using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject character_AxeOn;
    public GameObject mainCharacter;
    public GameObject Plane;
    public GameObject Axe;
    public Vector3 position;
    public int counter;

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
            if (Input.GetKey(KeyCode.E) && counter%2 == 0)
            {
                Axe.SetActive(false);
                mainCharacter.SetActive(false);
                character_AxeOn.SetActive(true);
                counter++;
            }

            if (Input.GetKey(KeyCode.F))
            {
                Axe.transform.position = character_AxeOn.transform.position;
                Axe.SetActive(true);
                mainCharacter.SetActive(true);
                character_AxeOn.SetActive(false);

            }
        }
    }
}
