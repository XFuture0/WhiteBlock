using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Itemimage : MonoBehaviour
{
    private Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public void UpdateImage(ItemData itemData)
    {
        image.sprite = itemData.ItemImage;
    }
}
