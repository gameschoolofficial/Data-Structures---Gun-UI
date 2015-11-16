using UnityEngine;
using System.Collections;
//Add the correct Collections library
using System.Collections.Generic;
using UnityEngine.UI;

public class GunBag : MonoBehaviour {
	
	public Image handgun;
	public Image SMG;
	public Image AK47;
	public Image RPG;
	public int currentImage;
	
	public Text numGuns;
	public Text nameGun;

	private List<Image> gunList;
	
	// Use this for initialization
	void Start () {
		//create a new List
		gunList = new List<Image> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Add 
	public void buyHandgun (){
		gunList.Add(handgun);
		nameGun.text = "Handgun";
		updateListTotal ();
	}
	public void buySMG (){
		gunList.Add(SMG);
		nameGun.text = "SMG";
		updateListTotal ();
	}
	public void buyQK47 (){
		gunList.Add(AK47);
		nameGun.text = "AK47";
		updateListTotal ();
	}
	public void buyRPG (){
		gunList.Add(RPG);
		nameGun.text = "RPG";
		updateListTotal ();
	}

	//Remove the last gun
	public void sellRandomGun(){		
		//add gun name to List
		gunList.RemoveAt(0);
		updateListTotal ();
	}

	public void updateListTotal(){
	
		numGuns.text = gunList.Count.ToString();
	}
}
