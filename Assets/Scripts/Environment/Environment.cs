using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour
{
    [SerializeField]
    private VacuumAgent _agent;

    [SerializeField]
    private Tile _tileA;

    [SerializeField]
    private Tile _tileB;

    private Tile _currentTile;

    private float _elaspedTime = 0; // in seconds
    private float _timeStep = 1; // in seconds

    private void Start()
    {
        _tileA.IsDirty = true;
        _tileB.IsDirty = true;
        _currentTile = _tileA;
    }

    private void Update()
    {
        _elaspedTime += Time.deltaTime;
        if (_elaspedTime >= _timeStep)
        {
            _agent.Run(this);
            _elaspedTime = 0;
        }
    }

    public Tile CurrentTile()
    {
        return _currentTile;
    }

    // Should be an actuator on the agent
    private void MoveLeft()
    {
        _currentTile = _tileA;
        _agent.transform.position = new Vector3(
            _currentTile.transform.position.x,
            _agent.transform.position.y,
            _agent.transform.position.z
        );
    }

    // Should be an actuator on the agent
    private void MoveRight()
    {
        _currentTile = _tileB;
        _agent.transform.position = new Vector3(
            _currentTile.transform.position.x,
            _agent.transform.position.y,
            _agent.transform.position.z
        );
    }

    // Should be on the agent
    public void Move()
    {
        if (_currentTile == _tileA)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }
    }
}
