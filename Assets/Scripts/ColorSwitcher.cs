using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    public GameObject CurrentColor;
    public GameObject NextColor;
    private void OnMouseDown()
    {
        CurrentColor.SetActive(false);
        NextColor.SetActive(true);
    }
}
