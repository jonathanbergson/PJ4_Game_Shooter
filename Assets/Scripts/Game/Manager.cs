using UnityEngine;

namespace Game
{
    public class Manager : MonoBehaviour
    {
        public static Manager Instance { get; private set; }

        private int _totalPoints;
        public int TotalPoints => _totalPoints;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }

        public void IncrementTotalPoints()
        {
            _totalPoints++;
        }
    }
}
