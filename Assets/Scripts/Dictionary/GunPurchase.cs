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
		imageTie[buySMG] = SMG;
		imageTie[buyAK47] = AK47;
		imageTie[buyRPG] = RPG;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void turnImageGreen(Button b)
	{
		imageTie[b].color = Color.green;
	}

	public void returnImageToWhite(Button b)
	{
		imageTie[b].color = Color.white;
	}
}
