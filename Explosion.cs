using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _radius = 10;
    [SerializeField] private float _force = 100;
    
    public void GetExplode()
    {
        Collider[] overlappedCollider = Physics.OverlapSphere(transform.position, _radius);

        for (int i = 0; i < overlappedCollider.Length; i++)
        {
            Rigidbody rigidbody = overlappedCollider[i].attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _radius);
            }
        }
    }
}