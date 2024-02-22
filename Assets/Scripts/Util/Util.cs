using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    public static GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        Transform transform = FindChild<Transform>(go, name, recursive);
        if (transform == null)
            return null;

        return transform.gameObject;
    }

    public static T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if (go == null)
            return null;

        if (!recursive)
        {
            Transform transform = go.transform;
            for (int i = 0; i < transform.childCount; i++)
            {
                if (string.IsNullOrEmpty(name) || transform.GetChild(i).name == name)
                {
                    T component = transform.GetComponent<T>();
                    if (component != null)
                        return component;
                }
            }
        }
        else
        {
            foreach (T component in go.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                    return component;
            }
        }

        return null;
    }

    public static Transform FindParentFromHUD(string name = null)
    {
        GameObject hud = GameObject.Find("UI_Hud");
        if (hud == null)
        {
            Debug.Log("���� ���� Hud�� �������� �ʽ��ϴ�.");
            return null;
        }

        Transform parent = FindChild<Transform>(hud, name, true);
        if (parent == null)
        {
            Debug.Log($"�ش� Transform�� �������� �ʽ��ϴ�. : {name}");
            return null;
        }

        return parent;
    }
}
