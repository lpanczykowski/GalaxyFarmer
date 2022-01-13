using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterPlant : MonoBehaviour
{
	public Button button;
	public Text text;

	void Start()
	{
		if(button != null) button.onClick.AddListener(WaterPlantOnClick);
		if(text != null) text.text = PlantProperties.WaterLevel.ToString() + "%";
	}

	void WaterPlantOnClick()
	{
		PlantProperties.WaterLevel += 20;
		text.text = PlantProperties.WaterLevel.ToString() + "%";
		Debug.Log("You have water a plant");
	}
}
