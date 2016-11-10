using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class LoadScene : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler {

    public Text timeText;
    public string sceneName;

    private bool isEnter = false;
    private float time = 0;

    public void OnPointerEnter(PointerEventData eventData)
    {
        isEnter = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        timeText.text = "LoadScene";
        isEnter = false;
        time = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (isEnter)
        {
            time += Time.deltaTime;
            if (0 <= time && time < 1)
                timeText.text = "5s";
            else if (1 <= time && time < 2)
                timeText.text = "4s";
            else if (2 <= time && time < 3)
                timeText.text = "3s";
            else if (3 <= time && time < 4)
                timeText.text = "2s";
            else if (4 <= time && time < 5)
                timeText.text = "1s";
            else
            {
                timeText.text = "LoadScene";
                EditorSceneManager.LoadScene(sceneName);
                isEnter = false;
                time = 0;
            }  
        }
	
	}
}
