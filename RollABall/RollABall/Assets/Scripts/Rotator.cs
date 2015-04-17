using UnityEngine;

namespace Assets.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public void Update()
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}