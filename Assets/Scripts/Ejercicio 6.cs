using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    [SerializeField] int fuerzaAceleracion;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direccion = new Vector3(1, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(direccion * fuerzaAceleracion, ForceMode.Acceleration);
        }

    }
}
