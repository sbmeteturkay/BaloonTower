//Authored by saban mete turkay demirkiran
//follow: https://github.com/sbmeteturkay

using UnityEngine;

namespace MeteTurkay{
	public class BaloonForce : MonoBehaviour
	{
		[SerializeField] Rigidbody rb;
        [Header("Info")]
        public float speed;
        private void Update()
        {
            speed = rb.velocity.magnitude;
            if (rb.position.y < 1.5)
            {
                rb.AddForce(Vector3.up, ForceMode.Force);
                rb.drag = 1;
            }
            else
            {
                rb.AddForce(-1*Vector3.up, ForceMode.Force);
                rb.drag = 10;
            }
        }
    }
}
