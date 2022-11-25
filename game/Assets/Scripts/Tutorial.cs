using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Button yourButton;
    private GameObject tut;
    private GameObject men;

    void Start () {

		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        men = GameObject.Find("Menu").gameObject;
        tut = GameObject.Find("Tutorial").gameObject;

        tut.SetActive(false);
	}

	void TaskOnClick(){
        men.SetActive(false);
        tut.SetActive(true);
	}
}
