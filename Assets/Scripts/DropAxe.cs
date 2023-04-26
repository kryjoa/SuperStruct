using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAxe : MonoBehaviour
{
    public GameObject AxeOff;

    void Start()
    {
        AxeOff.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F))
            {
                this.gameObject.SetActive(true);
                AxeOff.SetActive(false);
            }
        }
    }
}
