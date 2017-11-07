using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public static GameManager GetInstance()
    {
        return instance;
    }

    public enum State { PLAY, PAUSE }
    private State state;

    private void Awake()
    {
        instance = this;
        SetState(State.PLAY);
    }

    public void SetState(State newState)
    {
        state = newState;
    }
}
