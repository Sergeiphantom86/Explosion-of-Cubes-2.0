using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody), typeof(RandomColor))]

public class Separat : MonoBehaviour
{
    [SerializeField] private GameObject _newCube;

    private List<Rigidbody> _rigidbodysNewItem = new();
    private Explosion _explosion;

    private int _reductionFactor = 2;
    private static float _separation = 1;
    private float _chanc;

    private void Start()
    {
        _newCube = gameObject;
        _chanc = _separation;

        _explosion = gameObject.AddComponent<Explosion>();
    }

    private void OnMouseDown()
    {
        if (_chanc >= Random.value)
        {
            AddNewItem(_newCube);

            SetSplitChance(_chanc / _reductionFactor);

            _explosion.UseOnlyForNewObjects(_rigidbodysNewItem);
        }
        else
        {
            _explosion.UseAllObjects();
        }

        Destroy(gameObject);
    }

    private void AddNewItem(GameObject newCube)
    {
        int quantityItems = GetQuantityItems();

        for (int i = 0; i <= quantityItems; i++)
        {
            ReduceSize(СreateNewGameObject(newCube));

            _rigidbodysNewItem.Add(newCube.GetComponent<Rigidbody>());
        }
    }

    private GameObject СreateNewGameObject(GameObject newCube)
    {
        return Instantiate(newCube, transform.position, Random.rotation);
    }

    private int GetQuantityItems()
    {
        int minQuantity = 2;
        int maxQuantity = 6;

        return Random.Range(minQuantity, maxQuantity);
    }

    private void ReduceSize(GameObject newItem)
    {
        int scaleItem = 2;

        newItem.transform.localScale = transform.lossyScale / scaleItem;
    }

    private void SetSplitChance(float value)
    {
        _separation = value;
    }
}
