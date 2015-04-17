using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        private int _count;
        public float speed;

        public void FixedUpdate()
        {
            MovePlayer();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (!IsPickUpObject(other)) return;

            other.gameObject.SetActive(false);

            _count++;
        }

        public void Start()
        {
            _count = 0;
        }

        private static bool IsPickUpObject(Collider other)
        {
            return other.gameObject.tag == "PickUp";
        }

        private void MovePlayer()
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            var moveVertical = Input.GetAxis("Vertical");

            var rigidBody = GetComponent<Rigidbody>();

            var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rigidBody.AddForce(movement * speed * Time.deltaTime);
        }
    }
}