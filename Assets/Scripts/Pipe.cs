using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static float Speed = -0.3f;

    private void Start()
    {
        transform.Translate(new Vector3(0.0f, Random.Range(-0.5f, 0.5f), 0.0f));
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector3(Speed * Time.deltaTime, 0.0f, 0.0f));
        if (transform.position.x <= -3.1)
        {
            transform.Translate(new Vector3(6f, 0.0f, 0.0f));
            transform.position = new Vector3(transform.position.x, Random.Range(-0.5f, 0.5f), transform.position.z);
        }
    }
}
