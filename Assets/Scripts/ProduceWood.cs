using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProduceWood : MonoBehaviour
{
    public GameObject Palette;
    public GameObject character_AxeOn;
    
    // Start is called before the first frame update
    void Start()
    {
        character_AxeOn.SetActive(true);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        if (character_AxeOn.transform.position = Palette.transform.position;)
    //        {
    //            Abbauen();
    //        }
    //    }
    //}

    //public void Abbauen()
    //{

    //}
}
