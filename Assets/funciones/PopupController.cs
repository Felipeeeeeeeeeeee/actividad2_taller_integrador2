using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour {

	public GameObject canvasDialogo;
	private Animator anim;

	void Start()
	{
		anim = canvasDialogo.GetComponent<Animator>();
	}
	
	public void Mouse_Entra()
	{
		//Do something
		//cuadroDialogo.SetActive(true);
		anim.SetBool("funca", true);

	}

	public void Mouse_Sale()
	{

		anim.SetBool("funca", false);
		//cuadroDialogo.SetActive(false);
	}

}
