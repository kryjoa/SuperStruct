using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject character_AxeOn;
    public GameObject controllerOff;
    //public GameObject Maincharacter;
    //public Vector3 position;

    void Start()
    {
        character_AxeOn.SetActive(false);
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
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                controllerOff.SetActive(false);
                character_AxeOn.SetActive(true);
            }
        }
    }
}
