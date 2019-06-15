using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

	public Text ItemNameText;
	public Text ItemStatsText;

	public GameObject Tooltip;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	//Detect if the Cursor starts to pass over an item
	public void OnPointerEnter(PointerEventData pointerEventData)
	{
		//Active the Tooltip and set the name and the slot of the item
		ItemNameText.text = name.ToString();
		Tooltip.SetActive(true);

		//Set helmet stats
		if (name == "Helmet1")
		{
			ItemStatsText.text = "Armor +" + 10.ToString();
		}
		if (name == "Helmet2")
		{
			ItemStatsText.text = "Armor +" + 20.ToString();
		}
		if (name == "Helmet3")
		{
			ItemStatsText.text = "Armor +" + 30.ToString();
		}

		//Set sword stats
		if (name == "Sword1")
		{
			ItemStatsText.text = "Damage +" + 10.ToString();
		}
		if (name == "Sword2")
		{
			ItemStatsText.text = "Damage +" + 20.ToString();
		}
		if (name == "Sword3")
		{
			ItemStatsText.text = "Damage +" + 30.ToString();
		}
	}

	//Detect when Cursor leaves the item
	public void OnPointerExit(PointerEventData pointerEventData)
	{
		//Deactivate the tooltip
		Tooltip.SetActive(false);
	}
}
