using UnityEngine;

namespace NavGame.Misc
{
    public class Spinner : MonoBehaviour
    {
        public Vector3 eulersPerSecond;
        private void Update()
        {
            transform.Rotate(eulersPerSecond * Time.deltaTime);
        }
    }
}