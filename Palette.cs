using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private readonly List<Color> _colors = new();

    private void Start()
    {
        Replace();
    }

    public void Replace()
    {
        Add();

        gameObject.GetComponent<Renderer>().material.color = _colors[Random.Range(0, _colors.Count)];
    }

    private void Add()
    {
        _colors.Add(Color.red);
        _colors.Add(Color.green);
        _colors.Add(Color.blue);
        _colors.Add(Color.magenta);
        _colors.Add(Color.yellow);
        _colors.Add(Color.white);
        _colors.Add(Color.cyan);
    }
}
