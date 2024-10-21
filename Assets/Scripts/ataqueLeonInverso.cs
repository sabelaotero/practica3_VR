using System.Collections;
using UnityEngine;

public class ataqueLeonInverso : MonoBehaviour
{
    public float speed = 3f;
    public float moveTime = 10f;
    private bool movingLeft = true;

    void Start()
    {
        StartCoroutine(MoveLion());
    }

    IEnumerator MoveLion()
    {
        while (true)
        {
            yield return MoveInDirection(movingLeft ? Vector3.left : Vector3.right, moveTime);
            movingLeft = !movingLeft;
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

