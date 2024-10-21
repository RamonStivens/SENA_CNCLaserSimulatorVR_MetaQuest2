using UnityEngine;

public class SenaActions : MonoBehaviour
{
    public Animator animatorEngine;
    public string parameterStartAnimation;

    public void ActionEngine()
    {
        /*Add actions when press the button of the engine
         * Example: Enable animation*/

        animatorEngine.SetBool(parameterStartAnimation, true);
    }
}
