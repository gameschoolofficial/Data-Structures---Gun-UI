using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GunPurchase : MonoBehaviour {
	public Image handgun;
	public Button buyHandgun;
	public Image SMG;
	public Button buySMG;
	public Image AK47;
	public Button buyAK47;
	public Image RPG;
	public Button buyRPG;


	public Dictionary<Button, Image> imageTie = new Dictionary<Button, Image>();



	// Use this for initialization
	void Start () {
		imageTie[buyHandgun] = handgun;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void turnImageGreen(Button b)
	{
		imageTie[b].color = Color.green;
	}

	
}
