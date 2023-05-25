using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorController : MonoBehaviour
{
    public float speed = 0.1f; // Geschwindigkeit, mit der sich der Aufzug bewegt

    public int requiredResources = 10; // Die Anzahl der erforderlichen Ressourcen zum Auslösen des Aufzugs
    private int collectedResources = 10; // Die Anzahl der gesammelten Ressourcen
    private bool isMoving = false; // Überprüfung, ob der Aufzug sich gerade bewegt
    private Vector3 targetPosition; // Zielposition des Aufzugs
    private bool isInsideElevator = false;
    private Vector3 hoch;

    private void Update()
    {
        if (isMoving)
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collectedResources >= requiredResources)
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