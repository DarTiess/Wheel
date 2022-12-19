using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CirclePiece : MonoBehaviour
{
    public int price;
    [SerializeField] private Text priceText;

    private void Start()
    {
        priceText.text=price.ToString();
    }
}
