using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseScene : MonoBehaviour
{
    public Define.Scenes SceneType { get; protected set; }

    

    public virtual void Clear() { }
}
