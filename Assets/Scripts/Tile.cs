using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
    private bool _isDirty = false;

    public bool IsDirty
    {
        get
        {
            return _isDirty;
        }
        set
        {
            _isDirty = value;
            GetComponent<Renderer>().material.color = _isDirty ? Color.red : Color.white;
        }
    }
}
