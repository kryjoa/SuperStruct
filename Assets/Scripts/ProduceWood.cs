using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class ProduceWood : MonoBehaviour
{
    public GameObject Plank;
    public GameObject character_AxeOn;
    public float radius = 3f;
    public int i;
    public Vector3 Plankposition;
    public GameObject PlankCharacterOn;
    public GameObject mainCharacter;
    public int clonedPlankcounter = 1;
    public GameObject empty;
    

    public GameObject PlankTeil1;
    public GameObject PlankTeil2;
    public GameObject PlankTeil3;

    public GameObject Pallet;

    public int Packetcounter;

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
        if (other.gameObject.tag == "Player")
        {
            CreateEmptyObject();
        }
    }
    public void Spawn()
    {
        float distance = Vector3.Distance(transform.position, character_AxeOn.transform.position);

        if (gameObject == character_AxeOn.activeInHierarchy)
        {
            if (distance <= radius  && Pallet.activeSelf)
            {
                AddPartToEmptyObject();
            }
        }
    }
    private void CreateEmptyObject()
    {
        empty = new GameObject("Packet"); // Erstelle ein neues Empty Object
        clonedPlankcounter = 0; // Setze den Zähler für die Teile zurück
    }
    private void AddPartToEmptyObject()
    {
        if (clonedPlankcounter <= 4)
        {
            GameObject newPart = Instantiate(Plank, empty.transform); // Instanziere ein neues Teil und setze es als Kind des aktuellen Empty Objects
            newPart.SetActive(true); //clonedPlan spawnt

            Plank.transform.position += new Vector3(0f, 0.1f, 0f); //Plank jedes mal wenn eine abgebaut wird um 0.1f nach oben


            //Paletten despawnen lassen
            #region Palette abbauen
            newPart.name = Plank.name + " (" + i + ")";
            if (i == 1)
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
            #endregion

            clonedPlankcounter++; // Erhöhe den Zähler für die Teile

            if (clonedPlankcounter >= 3)
            {
                CreateEmptyObject(); // Wenn die maximale Anzahl der Teile erreicht ist, erstelle ein neues Empty Object
            }
        }
    }
}