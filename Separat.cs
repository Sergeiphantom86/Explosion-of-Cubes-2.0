using UnityEngine;

public class Separat : MonoBehaviour
{
    public static int Random(int min, int max)
    {
        return new System.Random().Next(min, max);
    }

    private void OnMouseDown()
    {
        if (gameObject.transform.lossyScale.x >= GetAbilityShare() / 100f)
        {
            AddNewItems();
           
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void AddNewItems()
    {
        int minQuantity = 2;
        int maxQuantity = 6;
        int scale = 2;

        gameObject.AddComponent<Palette>().GetTexturs();
        gameObject.AddComponent<Explosion>().GetExplode();

        for (int i = 0; i <= Random(minQuantity, maxQuantity); i++)
        {
            Instantiate(gameObject, transform.position, Quaternion.identity).transform.localScale = transform.lossyScale / scale;
        }
    }

    private float  GetAbilityShare()
    {
        return Random(0, 100);
    }
}