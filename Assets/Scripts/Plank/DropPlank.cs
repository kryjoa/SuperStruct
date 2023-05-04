using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPlank : MonoBehaviour
{
    public GameObject MainCharacter;
    public GameObject PlankCharacterOn;
    public GameObject Plank;

    void Start()
    {

    }

    void Update()
    {
        test();
    }



    void test()
    {
        if (PlankCharacterOn.activeSelf)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Vector3 position = PlankCharacterOn.transform.position;
                MainCharacter.transform.position = position;
                MainCharacter.SetActive(true);
                PlankCharacterOn.SetActive(false);
                Plank.SetActive(true);
                Plank.transform.position = PlankCharacterOn.transform.position;
                Plank.transform.rotation = PlankCharacterOn.transform.rotation;
            }
        }
    }
}