using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantInit : MonoBehaviour
{
    public Text text;

    void Start()
    {
        PlantProperties.WaterLevel = 80;

        if (text != null) text.text = PlantProperties.WaterLevel.ToString() + "%";
    }
}
