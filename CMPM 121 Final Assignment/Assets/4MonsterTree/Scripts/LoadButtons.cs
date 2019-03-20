using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadButtons : MonoBehaviour {

public GameObject prefabButton;
public GameObject avatar;

void Start()
	{
		int i = 0;
		foreach(AnimationState state in avatar.GetComponent<Animation>())
		{

			i++;

			GameObject goButton = Instantiate(prefabButton,prefabButton.transform.parent);

			Vector3 pos = goButton.transform.position;
				pos.y -= i*30f;
			goButton.transform.position = pos;

			goButton.GetComponentInChildren<Text>().text = state.clip.name;

			goButton.GetComponent<Button>().onClick.AddListener(() => { ButtonClicked(state.clip.name);});

		}

	}

	void ButtonClicked(string anim_name)
	{
		avatar.GetComponent<Animation>().CrossFade(anim_name, 0.3f); 	}
}

