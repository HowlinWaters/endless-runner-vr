using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Logic logic;
    public Transform head;
    public Transform feet;

    void Start()
    {
        // Find a single GameObject with the "Logic" tag and get the Logic component from it
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        if (logicObject != null)
        {
            logic = logicObject.GetComponent<Logic>();
        }
        else
        {
            Debug.LogWarning("Logic object not found. Please ensure it's tagged correctly in the scene.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Ensure logic is not null before calling gameOver
        if (logic != null)
        {
            logic.gameOver();
        }
        else
        {
            Debug.LogWarning("Logic component is not set. Game over cannot be processed.");
        }
    }

    private void Update()
    {
        gameObject.transform.position = new Vector3(head.position.x, feet.position.y, head.position.z);
    }
}
