using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daño : MonoBehaviour
{
    public static int health = 3; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Leon"))
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        health--;
        Debug.Log("Vidas restantes: " + health);

        if (health <= 0)
        {
            Debug.Log("El jugador ha sido derrotado.");
        }
    }
}

