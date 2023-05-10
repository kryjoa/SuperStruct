using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPlank : MonoBehaviour
{
    public GameObject MainCharacter;
    public GameObject PlankCharacterOn;
    public GameObject Planks; 

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
                Quaternion rotation = PlankCharacterOn.transform.rotation;
                MainCharacter.transform.position = position;
                MainCharacter.transform.rotation = rotation;
                PlankCharacterOn.SetActive(false);
                MainCharacter.SetActive(true);

                Planks.SetActive(true);
                Planks.transform.position = PlankCharacterOn.transform.position;
                
            }
        }
    }
}