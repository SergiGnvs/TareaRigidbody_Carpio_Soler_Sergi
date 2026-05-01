using UnityEngine;

public class Ejercicio3Coche : MonoBehaviour
{
    [SerializeField] int fuerzaAceleracion;
    [SerializeField] int fuerzaFrenado;
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
            rb.AddForce(transform.forward * fuerzaAceleracion, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * fuerzaFrenado, ForceMode.Force);
        }

    }
}
