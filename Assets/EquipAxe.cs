using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject AxeOn;

    void Start()
    {
        AxeOn.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                AxeOn.SetActive(true);
            }
        }
    }
}
