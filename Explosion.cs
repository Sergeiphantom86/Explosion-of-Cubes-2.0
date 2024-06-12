using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private int _explosionForce;
    private static int _temporaryForce = 50;

    private int _explosionRadius;
    private static int _temporaryRadius = 2;

    private static int _magnificatFactor = 2;
    private int _height = 2;

    private void Start()
    {
        _explosionRadius = _temporaryRadius;
        _explosionForce = _temporaryForce;
    }

    public void UseAllObjects()
    {
        Collider[] overlappedColliders = Physics.OverlapSphere(transform.position, _explosionRadius);

        foreach (var overlappedCollider in overlappedColliders)
        {
            Rigidbody rigidbody = overlappedCollider.attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius, _height);
            }
        }
    }

    public void UseOnlyForNewObjects(List<Rigidbody> RigidbodysNewCubes)
    {
        foreach (var RigidbodyNewCube in RigidbodysNewCubes)
        {
            RigidbodyNewCube.AddExplosionForce(_explosionForce, transform.position, _explosionRadius, _height);
        }

        IncreaseForce(_explosionForce * _magnificatFactor);
        IncreaseRadius(_explosionRadius + _magnificatFactor);
    }

    public void IncreaseForce(int increase)
    {
        _temporaryForce = increase;
    }

    public void IncreaseRadius(int increase)
    {
        _temporaryRadius = increase;
    }
}
