using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OnTriggerStay(Collider other)
	{
		if(other.gameObject.tag == "SavePoint" && Input.GetKeyDown(KeyCode.E))
		{
			SaveGame();
		}

		if (other.gameObject.tag == "Door" && Input.GetKeyDown(KeyCode.E))
		{
			End();
		}
	}

	public void SaveGame()
	{
		print("Saving");
	}

	public void End()
	{
		print("Finnish");
	}
}
