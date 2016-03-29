using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour
{
    float resetCoordinate_Z = -20.44f;
    float speed = -5f;
    float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.InverseTransformDirection(Vector3.forward) * speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, rotateSpeed));
        if (transform.position.z < resetCoordinate_Z)
        {
            gameObject.SetActive(false);
        }
    }
}
