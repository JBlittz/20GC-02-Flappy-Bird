using UnityEngine;

public class Scenario : MonoBehaviour
{
    public static float Speed = 0.1f;
    [SerializeField]
    private float type = 1.0f;

    void Update()
    {
        transform.Translate(new Vector3(-Speed * type * Time.deltaTime, 0.0f, 0.0f));
        if (transform.position.x <= -3.1)
        {
            transform.Translate(new Vector3(7.5f, 0.0f, 0.0f));
        }
    }
}
