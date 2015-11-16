using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunHighlighter : MonoBehaviour {

	public Image handgun;
	public Image SMG;
	public Image AK47;
	public Image RPG;
	public int currentImage;

	public Image[] gunArray;

	// Use this for initialization
	void Start () {
		
		//Extra Credit: Currently when this code runs, currentImage moves to position 1 when nextImage is called, so the SMG is highlighted first. 
		//How would you change it if you wanted to highlight the handgun on Play?
		currentImage = 0; 
		gunArray = new Image[] {handgun, SMG, AK47, RPG};
		nextImage();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void nextImage()
	{
		//turn off color for last image
		gunArray[currentImage].color = Color.white;

		//increase currentImage number unless it's at the end
		currentImage++;
		if(currentImage >= gunArray.Length)
		{
			currentImage = 0;
		}

		//turn new image to red
		gunArray[currentImage].color = Color.red;



	}

	public void prevImage()
	{
		//turn off color for last image
		gunArray[currentImage].color = Color.white;

		//increase currentImage number unless it's at the end
		currentImage--;
		if(currentImage < 0)
		{
			currentImage = gunArray.Length -1;
		}

		//turn new image to red
		gunArray[currentImage].color = Color.red;
	}
}
