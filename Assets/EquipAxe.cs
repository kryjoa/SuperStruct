using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipAxe : MonoBehaviour
{
    public GameObject Axe;
    public Transform AxeParent;
    // Start is called before the first frame update
    void Start()
    {
        Axe.GetComponent<Rigidbody>().isKinematic = true;
    }
    void Update()
    {
        //if (Input.GetKey(KeyCode.F))
        //{
        //    Drop();
        //}
    }
    //void Drop()
    //{
    //    AxeParent.DetachChildren();
    //    Axe.transform.eulerAngles = new Vector3(Axe.transform.position.x);
    //    Axe.GetComponent<Rigidbody>().isKinematic = false;
    //    Axe.GetComponent<MeshCollider>().enabled = true;
    //}


    void Equip()
    {
        Axe.GetComponent<Rigidbody>().isKinematic = true;

        Axe.transform.position = AxeParent.transform.position;
        Axe.transform.rotation = AxeParent.transform.rotation;

        Axe.GetComponent<MeshCollider>().enabled = false;
        Axe.transform.SetParent(AxeParent);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Equip();
            }
        }
    }
}



