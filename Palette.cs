using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private readonly List<UnityEngine.Color> _colors = new();

    public void Replace()
    {
        AddColors();

        gameObject.GetComponent<Renderer>().material.color = _colors[Random.Range(0, _colors.Count)];
    }

    private void AddColors()
    {
        _colors.Add(UnityEngine.Color.red);
        _colors.Add(UnityEngine.Color.green);
        _colors.Add(UnityEngine.Color.blue);
        _colors.Add(UnityEngine.Color.magenta);
        _colors.Add(UnityEngine.Color.yellow);
        _colors.Add(UnityEngine.Color.white);
        _colors.Add(UnityEngine.Color.cyan);
    }
}
