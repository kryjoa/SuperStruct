using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropAxe : MonoBehaviour
{
    public GameObject player;
    public GameObject character_AxeOn;
    public GameObject Axe;

    void Start()
    {

    }

    void Update()
    {
        test();
    }



    void test()
    {
        if (character_AxeOn.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Vector3 position = character_AxeOn.transform.position;
                player.transform.position = position;
                player.SetActive(true);
                character_AxeOn.SetActive(false);
                Axe.SetActive(true);
                Axe.transform.position = character_AxeOn.transform.position;
                Axe.transform.rotation = character_AxeOn.transform.rotation;
            }
        }
    }
}
