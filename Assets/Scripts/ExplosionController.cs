using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    [SerializeField] int fuerzaExplosion;
    [SerializeField] int radioExplosion;
    [SerializeField] int upwardsModifier;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 explosionPosition = transform.position;

            Collider[] colliders = Physics.OverlapSphere(explosionPosition, radioExplosion);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(fuerzaExplosion, explosionPosition, radioExplosion, 3.0f);
            }
        }
    }
}
