using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Palette : MonoBehaviour
{
    private readonly List<Color> _colors = new();

    public void GetTexturs()
    {
        Add();

        gameObject.GetComponent<Renderer>().material.color = _colors.ElementAt(Separat.Random(0, _colors.Count));
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
        _colors.Add(Color.black);
        _colors.Add(Color.gray);
    }
}