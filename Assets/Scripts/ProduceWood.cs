using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;


public class ProduceWood : MonoBehaviour
{
    public GameObject Plank;
    public GameObject character_AxeOn;
    public float radius = 1f;
    public GameObject EmptyGameObject;
    public GameObject duplicatedObject;
    public int i;
    public Vector3 Plankposition;
    public GameObject PlankCharacterOn;
    public GameObject mainCharacter;


    public GameObject Planks;

    public GameObject PlankTeil1;
    public GameObject PlankTeil2;
    public GameObject PlankTeil3;

    public GameObject Pallet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }

    void Update()
    {
        if (mainCharacter.activeSelf)
        {
            PlankCharacterOn.transform.position = mainCharacter.transform.position;
            PlankCharacterOn.transform.rotation = mainCharacter.transform.rotation;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        GameObject clonedPlank = Instantiate(Plank, Plank.transform.position, Plank.transform.rotation);
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                clonedPlank.SetActive(false);
                mainCharacter.SetActive(false);
                PlankCharacterOn.SetActive(true);
            }
        }
    }
    public void Spawn()
    {
        float distance = Vector3.Distance(transform.position, character_AxeOn.transform.position);
        if (gameObject == character_AxeOn.activeInHierarchy)
        {
            if (distance <= radius  && Pallet.activeSelf)
            {
                //Plank.transform.position = EmptyGameObject.transform.position;

                GameObject clonedPlank = Instantiate(Plank, Plank.transform.position, Plank.transform.rotation);
                clonedPlank.transform.parent = Planks.transform;
                clonedPlank.SetActive(true);
                Plank.transform.position += new Vector3(0f, 0.1f, 0f);

                Plankposition = new Vector3(10f, 0f, 1f);


                clonedPlank.name = Plank.name + " (" + i + ")";
                if(i == 1)
                {
                    PlankTeil1.SetActive(false);
                }
                else if (i == 2)
                {
                    PlankTeil2.SetActive(false);
                }
                else if (i == 3)
                {
                    PlankTeil3.SetActive(false);
                }
                
                else if (i == 4)
                {
                    Pallet.SetActive(false);
                }
                i++;
            }
        }
    }
}