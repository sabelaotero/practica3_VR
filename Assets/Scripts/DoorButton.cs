using UnityEngine;
using System.Collections;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorButton : MonoBehaviour
{
    public GameObject leftDoor;  
    public GameObject rightDoor;  
    public Transform leftOpenPosition; 
    private Vector3 leftVector = new Vector3(2.5f, 0, -3.00419998f);
    public Transform rightOpenPosition;
    private Vector3 rightVector = new Vector3(-0.870000005f, 0.00592592033f, -3.00419998f);  
    private bool isOpening = false;

    public void OpenDoor()
    {
        if (!isOpening)
        {
            isOpening = true;
            StartCoroutine(OpenDoors());
        }
    }

    private IEnumerator OpenDoors()
    {
        leftOpenPosition.position = leftVector;
        rightOpenPosition.position = rightVector;
        Vector3 leftInitialPosition = leftDoor.transform.position;
        Vector3 rightInitialPosition = rightDoor.transform.position;
        leftDoor.transform.position = leftOpenPosition.position;
        rightDoor.transform.position = rightOpenPosition.position;
        yield return null;
    }
}
