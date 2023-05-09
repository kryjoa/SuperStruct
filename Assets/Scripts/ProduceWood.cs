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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }

    void Update()
    {
        PlankCharacterOn.transform.position = mainCharacter.transform.position;
        PlankCharacterOn.transform.rotation = mainCharacter.transform.rotation;
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
            if (distance <= radius)
            {
                //Plank.transform.position = EmptyGameObject.transform.position;

                GameObject clonedPlank = Instantiate(Plank, Plank.transform.position, Plank.transform.rotation); 
                clonedPlank.SetActive(true);
                Plank.transform.position += new Vector3(0f, 0.1f, 0f);

                Plankposition = new Vector3(10f, 0f, 1f);


                clonedPlank.name = Plank.name + " (" + i + ")";
                i++;
            }
        }
    }
}