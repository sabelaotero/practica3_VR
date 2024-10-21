using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class activarLuz : MonoBehaviour
{

    public Light luz;
    public GameObject teleport;

    void Start()
    {
        teleport.SetActive(false);
        if (luz != null)
        {
            luz.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("teleport"))
        {
            if (luz != null)
            {
                luz.enabled = true;
                teleport.SetActive(true);
            }
        }
    }

}
