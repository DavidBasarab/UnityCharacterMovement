using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        private Vector3 offset;
        public GameObject player;

        public void LateUpdate()
        {
            transform.position = player.transform.position + offset;
        }

        public void Start()
        {
            offset = transform.position;
        }
    }
}