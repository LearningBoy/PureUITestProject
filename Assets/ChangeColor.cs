using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColor : MonoBehaviour , IPointerExitHandler,IPointerEnterHandler
{

    public Renderer cube;
    public Material material;
    public Material material_1;
    public Material material_2;

    private int currentMaterial = 0;
    
    bool isChanged = false;
    bool isEnter = false;

    float time = 0;
	
	// Update is called once per frame
	void Update () {

        if (isEnter)
        {
            time += Time.deltaTime;
            if (time > 3)
            {
                switch (currentMaterial)
                {
                    case 0:
                        currentMaterial = 1;
                        cube.material = material_1;
                        break;
                    case 1:
                        currentMaterial = 2;
                        cube.material = material_2;
                        break;
                    default:
                        currentMaterial = 0;
                        cube.material = material;
                        break;
                }
                time = 0;
            }
        }
	}

    public void OnPointerExit(PointerEventData eventData)
    {
        time = 0;
        isEnter = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isEnter = true;
    }
}
