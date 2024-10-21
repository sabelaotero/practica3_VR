using System.Collections;
using UnityEngine;

public class ataqueLeon : MonoBehaviour
{
    public float speed = 3f; 
    public float moveTime = 10f; 
    private bool movingRight = true; 

    void Start()
    {
        StartCoroutine(MoveLion());
    }

    IEnumerator MoveLion()
    {
        while (true)
        {
            yield return MoveInDirection(movingRight ? Vector3.right : Vector3.left, moveTime);
            movingRight = !movingRight; 
        }
    }

    IEnumerator MoveInDirection(Vector3 direction, float duration)
    {
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
            elapsedTime += Time.deltaTime;
            yield return null; 
        }
    }
}

