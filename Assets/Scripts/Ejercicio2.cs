using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    [SerializeField] int fuerza;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * fuerza, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * fuerza, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * fuerza, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * fuerza, ForceMode.Force);
        }
    }
}
