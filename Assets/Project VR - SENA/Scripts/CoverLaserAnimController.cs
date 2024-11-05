using UnityEngine;

public class CoverLaserAnimController : MonoBehaviour
{
    public Animator animatorCover;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animatorCover = GetComponent<Animator>();
    }

    public void ActionOpenLaserCover()
    {
        animatorCover.SetInteger("CoverAnimID", 1);
    }
    public void ActionCloseLaserCover()
    {
        animatorCover.SetInteger("CoverAnimID", 2);
    }
}
