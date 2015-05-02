using UnityEngine;
using System.Collections.Generic;

public class VacuumAgent : MonoBehaviour
{
    private DirtSensor _dirtSensor;

    private void Start()
    {
        _dirtSensor = new DirtSensor();
    }

    // Should be converted to an actuator
    private void Vacuum(Tile tile)
    {
        tile.IsDirty = false;
    }

    // Maybe run shouldn't take the whole environment
    public void Run(Environment environment)
    {
        if (_dirtSensor.Perceive(environment) == 1) // magic numbers are the best
        {
            Vacuum(environment.CurrentTile());
        }
        else 
        {
            environment.Move();
        }
    }

}
