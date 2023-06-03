using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorController : MonoBehaviour
{
    public float speed = 0.1f; // Geschwindigkeit, mit der sich der Aufzug bewegt
    private bool isMoving = false; // Überprüfung, ob der Aufzug sich gerade bewegt
    private Vector3 targetPosition; // Zielposition des Aufzugs
    private Vector3 hoch;

    private bool isInsideElevator = false;

    public int requiredPlanks = 1; // Die Anzahl der erforderlichen Ressourcen zum Auslösen des Aufzugs

    private int collectedPlanks = 0; // Die Anzahl der gesammelten Ressourcen

    private void Update()
    {
        if (isMoving) //für bewegen
        {
            Vector3 moveDirection = targetPosition - transform.position;
            if (moveDirection.magnitude > 0.01f)
            {
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                isMoving = false;
            }
        }

        if (isInsideElevator)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                MoveUp();
            }
        }
    }
    //collision bei plank in Aufzug, dann collected++, dann auf required == collected, 
    //dann ob player in aufzug, dann g drücken, yallah
    private void OnCollisionEnter(Collision collision)
    {
        if (collectedPlanks >= requiredPlanks)
        {
            if (collision.gameObject.tag == "Player")
            {
                isInsideElevator = true;
                Debug.Log("Du bist in den Aufzug eingestiegen. Drücke G, um hinaufzufahren.");
            }
            else
            {
                Debug.Log("Du hast nicht genügend Ressourcen gesammelt, um den Aufzug zu benutzen.");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Holzteil"))
        {
            collectedPlanks++; // Erhöhe den Zähler um 1
            Debug.Log("Holzteil in den Aufzug gelegt. Aktueller Zähler: " + collectedPlanks);
        }
    }



    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isInsideElevator = false;
        }
    }

    public void MoveUp()
    {
        hoch = new Vector3(0f, 5f, 0f);
        if (!isMoving)
        {
            isMoving = true;
            targetPosition = transform.position + hoch; // Neues Ziel der Aufzugsposition (hier eine Einheit nach oben)
        }
    }
}