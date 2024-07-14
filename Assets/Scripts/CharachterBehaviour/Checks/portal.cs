using UnityEngine;

namespace BHS
{
    public class portal: MonoBehaviour
    {
        [SerializeField] private portal toPortal;
        [SerializeField] private float portalWindowTime;
        public static bool tpActive;

        void Start()
        {
            tpActive = true;
        }

        private void ResetPortal()
        {
            tpActive = true;
        }

        private void OnTriggerStay2D(Collider2D other)
        {
          Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (tpActive)
            {
                tpActive = false;
                float magnitude = rb.velocity.magnitude;
                rb.velocity = Vector2.zero;
                Vector2 direction = toPortal.transform.TransformDirection(Vector2.right) - transform.TransformDirection(Vector2.left);
                other.transform.position = toPortal.transform.position;
                rb.AddForce(direction * magnitude, ForceMode2D.Impulse);
            }

        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (tpActive == false)
            {
                Invoke(nameof(ResetPortal), portalWindowTime);
            }
        }



    }
}
