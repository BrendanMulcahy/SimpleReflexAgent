using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private bool _isDirty;

    public bool IsDirty
    {
        get { return _isDirty; }
        set
        {
            _isDirty = value;
            GetComponent<Renderer>().material.color = _isDirty ? Color.red : Color.white;
        }
    }

    public void Run()
    {
        if (!IsDirty && Random.Range(0f, 1f) > 0.75f)
        {
            IsDirty = true;
        }
    }
}