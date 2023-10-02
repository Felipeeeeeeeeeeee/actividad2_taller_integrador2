using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class cambioescena : MonoBehaviour {
	public string escena;
	public void cambiarescena(){

		SceneManager.LoadScene(escena);
	}
}
