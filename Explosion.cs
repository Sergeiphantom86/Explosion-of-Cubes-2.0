using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 2;
    [SerializeField] private float _explosionForce = 100;

    public void UseExplosion(List<Rigidbody> RigidbodysNewCubes)
    {
        foreach(var RigidbodyNewCube in RigidbodysNewCubes)
        {
            RigidbodyNewCube.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }
    }
}
