using UnityEngine;

public class VacuumAgent : MonoBehaviour
{
    private DirtSensor _dirtSensor;

    [SerializeField] private int score;

    private void Start()
    {
        _dirtSensor = new DirtSensor();
    }

    // Should be converted to an actuator
    private void Vacuum(Tile tile)
    {
        tile.IsDirty = false;
        score += 5;
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