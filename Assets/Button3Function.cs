using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button3Function : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

    // Add an image as child to your button object and set its image type to Filled. 
    // Assign it to this field in inspector.
    public Image progressImage;

    bool isEntered = false;

    float timeElapsed = 0;
    float GazeActivationTime = 3;

    // Update is called once per frame
    void Update () {

        if (isEntered)
        {
            timeElapsed += Time.deltaTime;
            progressImage.fillAmount = Mathf.Clamp(timeElapsed / GazeActivationTime, 0, 1);
            if (timeElapsed >= GazeActivationTime)
            {
                timeElapsed = 0;
                isEntered = false;
            }
        }
        else
        {
            timeElapsed = 0;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isEntered = true;
        progressImage.fillAmount = 0;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isEntered = false;
        progressImage.fillAmount = 100;
    }
}