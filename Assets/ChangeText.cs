using UnityEngine;
using UnityEngine.UI;

namespace VRStandardAssets.Utils

{
    public class ChangeText : MonoBehaviour
    {

        [SerializeField]
        private Text buttonText;

        public void Change()
        {
            if (buttonText.text.Equals("Change"))
                buttonText.text = "Click Event";
            else
                buttonText.text = "Change";
        }
    }
}