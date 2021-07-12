using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnded : MonoBehaviour
{
    public void KillObjectAfterAnimationEnd()
    {
        Destroy(this.gameObject);
    }
}
