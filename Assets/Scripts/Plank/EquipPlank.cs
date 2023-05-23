using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipPlank : MonoBehaviour
{
    public GameObject PlankCharacterOn;
    public GameObject MainCharacter;
    public GameObject Planks;
    public GameObject AxeCharacter;
    public GameObject Axt;
    public GameObject Bucket_Character;
    public GameObject bucket;





    void Start()
    {

    }
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {

                if (MainCharacter.activeSelf)
                {
                    MainCharacter.SetActive(false);
                    PlankCharacterOn.SetActive(true);
                    Planks.SetActive(false);
                }


                else if (Bucket_Character.activeSelf)
                {
                    PlankCharacterOn.transform.position = Bucket_Character.transform.position;
                    PlankCharacterOn.transform.rotation = Bucket_Character.transform.rotation;
                    Vector3 position = PlankCharacterOn.transform.position;
                    position.z = position.z + 1f;
                    bucket.transform.position = position;
                    bucket.SetActive(true);
                }

                else if (AxeCharacter.activeSelf)
                {
                    PlankCharacterOn.transform.position = AxeCharacter.transform.position;
                    PlankCharacterOn.transform.rotation = AxeCharacter.transform.rotation;
                    Vector3 position = PlankCharacterOn.transform.position;
                    position.z = position.z + 1f;
                    Axt.transform.position = position;
                    Axt.SetActive(true);
                }



                MainCharacter.SetActive(false);
                Bucket_Character.SetActive(false);
                AxeCharacter.SetActive(false);
                PlankCharacterOn.SetActive(true);

                Planks.SetActive(false);





            }
        }
    }
}