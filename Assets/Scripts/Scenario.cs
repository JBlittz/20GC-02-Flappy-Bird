using UnityEngine;

public class Scenario : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;

    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f));
        if (transform.position.x <= -3.1)
        {
            transform.Translate(new Vector3(7.5f, 0.0f, 0.0f));
        }
    }
}
