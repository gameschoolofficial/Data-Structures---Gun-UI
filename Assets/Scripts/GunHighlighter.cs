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

	
}
