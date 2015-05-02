using UnityEngine;
using System.Collections;

public class DirtSensor : ISensor
{
    public float Perceive(Environment environment)
    {
        return environment.CurrentTile().IsDirty ? 1 : 0;
    }
}
