using UnityEngine;

public class StartLaserAnim : MonoBehaviour
{
    public Animator animatorLaser;

    public string nameParameterStartAnimation;

    public void ActionLaserEngineWorking()
    {
        /*Add actions when press the button of the engine
         * Example: Enable animation*/

        animatorLaser.SetBool(nameParameterStartAnimation, true);
    }

}
