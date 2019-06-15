using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	[SerializeField]
	private float _SpeedMovement = 5.0f;
	[SerializeField]
	private float _SpeedTurn = 150.0f;

	public static bool move = true;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (move)
		{
			var x = Input.GetAxis("Horizontal") * Time.deltaTime * _SpeedTurn;
			var z = Input.GetAxis("Vertical") * Time.deltaTime * _SpeedMovement;

			transform.Rotate(0, x, 0);
			transform.Translate(0, 0, z);
		}
	}
}
