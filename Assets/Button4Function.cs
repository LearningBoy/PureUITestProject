using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.EventSystems;

public class Button4Function : MonoBehaviour, IPointerEnterHandler
{

    public string sceneName;

    float time = 0;
    bool isEnter = false;

    // Update is called once per frame
    void Update()
    {

        if (isEnter)
        {
            time += Time.deltaTime;

            if (time > 3)
            {
                EditorSceneManager.LoadScene(sceneName);
            }
        } 

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isEnter = true;
    }

}
