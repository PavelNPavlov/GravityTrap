namespace GravityTrap.Mechanics
{
    using UnityEngine;

    using Core;

    public class RedShape : InteractableObject
    {

        void Start()
        {
            this.SetColors();
            Debug.Log("Red Shape Created");
        }

        void Update()
        {

        }

        public override void SetColors()
        {
            base.SetColors();

            this.Colors.Add(ForceColor.Red);
        }
    }
}
