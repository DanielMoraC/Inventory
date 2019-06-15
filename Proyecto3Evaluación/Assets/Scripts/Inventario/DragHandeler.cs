using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	//Sword = 1  Helmet = 2
	public int IDItem;

	public bool possible = false;
	public bool possibleI = true;

	public Transform HelmetSlot;
	public Transform SwordSlot;
	public Transform RandomSlot;

	Vector3 startPosition;
	Transform startParent;

	//When the player clicks on an item the position and the initial parent is set
	public void OnBeginDrag(PointerEventData eventData){
		startPosition = transform.position;
		startParent = transform.parent;
	}

	//When the player is moving the item it follows the mouse
	public void OnDrag(PointerEventData eventData){
		transform.position = Input.mousePosition;
	}

	//when the player releases the click if the item is on the inventory or in its slot and there is space the object is placed where you leave it
	public void OnEndDrag(PointerEventData eventData){

		Detector slotH = HelmetSlot.GetComponent<Detector>();
		Detector slotS = SwordSlot.GetComponent<Detector>();

		//Helmet
		if (IDItem == 2)
		{
			if (!possible)
			{
				transform.position = startPosition;
			}
			else if (possible && slotH.maximoH == 1)
			{
				gameObject.transform.SetParent(HelmetSlot);
			}

			if (!possibleI)
			{
				transform.position = startPosition;
			}
			else if (possibleI)
			{
				gameObject.transform.SetParent(RandomSlot);
			}
		}

		//Sword
		if (IDItem == 1)
		{
			if (!possible)
			{
				transform.position = startPosition;
			}
			else if (possible && slotS.maximoS == 1)
			{
				gameObject.transform.SetParent(SwordSlot);
			}

			if (!possibleI)
			{
				transform.position = startPosition;
			}
			else if (possibleI)
			{
				gameObject.transform.SetParent(RandomSlot);
			}
		}
	}

	//To know where the item is placed and can be placed
	public void OnTriggerEnter2D(Collider2D collision)
	{
		//Helmet
		if (IDItem == 2)
		{
			if (collision.gameObject.tag == "Helmet")
			{
				possible = true;
			}

			if (collision.gameObject.tag == "Inventory")
			{
				possibleI = true;
				RandomSlot = collision.gameObject.transform;
			}
		}

		//Sword
		if (IDItem == 1)
		{
			if (collision.gameObject.tag == "Sword")
			{
				possible = true;
			}

			if (collision.gameObject.tag == "Inventory")
			{
				possibleI = true;
				RandomSlot = collision.gameObject.transform;
			}
		}
	}

	//To know where the item is placed and can be placed
	public void OnTriggerExit2D(Collider2D collision)
	{
		//Helmet
		if (IDItem == 2)
		{
			if (collision.gameObject.tag == "Helmet")
			{
				possible = false;
			}

			if (collision.gameObject.tag == "Inventory")
			{
				possibleI = false;
			}
		}

		//Sword
		if (IDItem == 1)
		{
			if (collision.gameObject.tag == "Sword")
			{
				possible = false;
			}

			if (collision.gameObject.tag == "Inventory")
			{
				possibleI = false;
			}
		}
	}

}
