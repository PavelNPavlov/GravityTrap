namespace GravityTrap.Managers
{
    using UnityEngine;
    using System.Collections;
    using Mechanics.Atractors;
    using Helpers;
    using Mechanics.Core;
    public class LevelManger : MonoBehaviour
    {

        public GameObject AtractorObject;
        
        private Vector3 target;
        private Atractor atractor;

        // Use this for initialization
        void Start()
        {
            this.AtractorObject = GameObject.FindGameObjectWithTag(TagConstants.AtractorTag);

            this.atractor = this.AtractorObject.GetComponent<Atractor>();
            Debug.Log("LevelStarted");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;

                Debug.Log(target);
            }

            //temp control Scheme
            if (Input.GetKeyDown(KeyCode.A))
            {
                this.atractor.ChangeColor(ForceColor.Red);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                this.atractor.ChangeColor(ForceColor.Blue);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                this.atractor.ChangeColor(ForceColor.Green);
            }
        }
    }
}
