using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class contadorMonedas : MonoBehaviour
{
    public static int coinCount = 0;

    public Light indicatorLight;

    public GameObject door;
    private XRGrabInteractable doorInteractable;

    void Start()
    {
        doorInteractable = door.GetComponent<XRGrabInteractable>();
        ResetCoinCount();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) 
        {
            coinCount++;
            Debug.Log("Monedas en la bañera: " + coinCount);

            if (coinCount >= 6)
            {
                TurnOnLight();
                ActivateDoorInteractable();
            }
        }
    }

    private void TurnOnLight()
    {
        if (indicatorLight != null)
        {
            indicatorLight.enabled = true; 
            Debug.Log("¡La luz se ha encendido!");
        }
    }

    private void ActivateDoorInteractable()
    {
        if (doorInteractable != null)
        {
            doorInteractable.interactionLayers = LayerMask.GetMask("Default"); 
        }
    }

    public void ResetCoinCount()
    {
        coinCount = 0;
        if (indicatorLight != null)
        {
            indicatorLight.enabled = false; 
        }
    }
}
