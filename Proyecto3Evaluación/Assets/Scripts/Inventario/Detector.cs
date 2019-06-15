using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour {

	//Sword = 1  Helmet = 2
	public int IDSlot;
	public int maximoH = 0;
	public int maximoS = 0;

	public GameObject Stats;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void OnTriggerEnter2D(Collider2D collision)
	{

		Stats stats = Stats.GetComponent<Stats>();

		//To detect if the slot is occupied
		if (IDSlot == 1)
		{
			maximoS++;
		}
		if (IDSlot == 2)
		{
			maximoH++;
		}

		//Change Sword Stats
		if (IDSlot == 1 && maximoS == 1)
		{
			if (collision.gameObject.name == "Sword1")
			{
				stats.DamagePoints += 10;
			}
			if (collision.gameObject.name == "Sword2")
			{
				stats.DamagePoints += 20;
			}
			if (collision.gameObject.name == "Sword3")
			{
				stats.DamagePoints += 30;
			}
		}

		//Change Helmet Stats
		if (IDSlot == 2 && maximoH == 1)
		{
			if (collision.gameObject.name == "Helmet1")
			{
				stats.ArmorPoints += 10;
			}
			if (collision.gameObject.name == "Helmet2")
			{
				stats.ArmorPoints += 20;
			}
			if (collision.gameObject.name == "Helmet3")
			{
				stats.ArmorPoints += 30;
			}
		}
	}

	public void OnTriggerExit2D(Collider2D collision)
	{

		Stats stats = Stats.GetComponent<Stats>();

		//To detect if the slot is occupied
		if (IDSlot == 1)
		{
			maximoS--;
		}
		if (IDSlot == 2)
		{
			maximoH--;
		}

		//Change Sword Stats
		if (IDSlot == 1 && maximoS != 1)
		{
			if (collision.gameObject.name == "Sword1")
			{
				stats.DamagePoints -= 10;
			}
			if (collision.gameObject.name == "Sword2")
			{
				stats.DamagePoints -= 20;
			}
			if (collision.gameObject.name == "Sword3")
			{
				stats.DamagePoints -= 30;
			}
		}

		//Change Helmet Stats
		if (IDSlot == 2 && maximoH != 1)
		{
			if (collision.gameObject.name == "Helmet1")
			{
				stats.ArmorPoints -= 10;
			}
			if (collision.gameObject.name == "Helmet2")
			{
				stats.ArmorPoints -= 20;
			}
			if (collision.gameObject.name == "Helmet3")
			{
				stats.ArmorPoints -= 30;
			}
		}
	}
}
