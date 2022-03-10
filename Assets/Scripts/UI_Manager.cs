using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
	public Image UIimage;
	public GameObject image;
	public bool IsImageOn;
	public Slider red;
	public Slider blue;
	public Slider green;

	// Update is called once per frame
	void Update()
    {
       
    }
	public void OnEdit()
	{
		Color color = UIimage.color;
		color.r = red.value;
		color.b = blue.value;
		color.g = green.value;
		UIimage.color = color; 
	}
	public void OnClick()
	{
		HideShowImage();
	}

	public void HideShowImage()
	{
		if (IsImageOn == false)
		{
			IsImageOn = true;
			image.SetActive(true);
		}
		else if (IsImageOn == true)
		{
			IsImageOn = false;
			image.SetActive(false);
		}
	}
}
