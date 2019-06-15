using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

	[System.NonSerialized]
	public int DamagePoints = 10;
	[System.NonSerialized]
	public int ArmorPoints = 0;

	[System.NonSerialized]
	public int CurrentHealthPoints = 100;
	[System.NonSerialized]
	public int MaxHealthPoints = 200;

	//[System.NonSerialized]
	public int CurrentExpPoints = 0;
	[System.NonSerialized]
	public int MaxExpPoints = 0;

	//Level 2 = 200Exp  Level 3 = 400Exp  Level 4 = 600Exp  Level 5 = 800Exp  Level 6 = 1000Exp
	[System.NonSerialized]
	public int Level = 1;

	public Text DamageText;
	public Text ArmorText;
	public Text HealthText;
	public Text LevelText;
	public Text ExpText;

	// Use this for initialization
	void Start ()
	{
		DamageText.text = DamagePoints.ToString();
		ArmorText.text = ArmorPoints.ToString();
		HealthText.text = CurrentHealthPoints.ToString() + "/" + MaxHealthPoints.ToString();
		ExpText.text = CurrentExpPoints.ToString() + "/" + MaxExpPoints.ToString();
		LevelText.text = Level.ToString();
	}
	
	// Update is called once per frame
	void Update ()
	{

		//Level Up
		#region Level
		if (Level == 1)
		{
			MaxExpPoints = 200;
			if (CurrentExpPoints >= 200)
			{
				Level = 2;
			}
		}
		else if (Level == 2)
		{
			MaxExpPoints = 400;
			if (CurrentExpPoints >= 400)
			{
				Level = 3;
			}
		}
		else if (Level == 3)
		{
			MaxExpPoints = 600;
			if (CurrentExpPoints >= 600)
			{
				Level = 4;
			}
		}
		else if (Level == 4)
		{
			MaxExpPoints = 800;
			if (CurrentExpPoints >= 800)
			{
				Level = 5;
			}
		}
		else if (Level == 5)
		{
			MaxExpPoints = 1000;
			if (CurrentExpPoints >= 1000)
			{
				Level = 6;
			}
		}
		#endregion Level


		StatsReload();
	}

	//Set the stats on screen
	public void StatsReload()
	{
		DamageText.text = DamagePoints.ToString();
		ArmorText.text = ArmorPoints.ToString();
		HealthText.text = CurrentHealthPoints.ToString() + "/" + MaxHealthPoints.ToString();
		ExpText.text = CurrentExpPoints.ToString() + "/" + MaxExpPoints.ToString();
		LevelText.text = Level.ToString();
	}
}
