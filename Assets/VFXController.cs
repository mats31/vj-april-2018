using UnityEngine;
using UnityEngine.Experimental.VFX;

sealed class VFXController : MonoBehaviour
{
    public VisualEffect _target = null;
    public string _parameterName = "";

    public float parameterValue {
        set { _target.SetFloat(_parameterName, value); }
    }
}
