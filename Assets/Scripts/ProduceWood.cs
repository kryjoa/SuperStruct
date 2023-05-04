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

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }

    public void Spawn()
    {
        float distance = Vector3.Distance(transform.position, character_AxeOn.transform.position);
        if (gameObject == character_AxeOn.activeInHierarchy)
        {
            if (distance <= radius)
            {
                Plank.transform.position = EmptyGameObject.transform.position;
                Plank.SetActive(true);
                Plank.transform.position += new Vector3(0f, 0.1f, 0f);
                Instantiate(Plank, Plank.transform.position, Plank.transform.rotation);
            }
        }
    }
}
