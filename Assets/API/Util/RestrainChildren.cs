﻿using UnityEngine;

namespace Genso.API {

    [RequireComponent(typeof(BoxCollider))]
    public class RestrainChildren : MonoBehaviour {

        private BoxCollider bounds;

        void Awake() {
            bounds = GetComponent<BoxCollider>();
            bounds.enabled = false;
        }

        void LateUpdate() {
            var boundedArea = new Bounds(bounds.center, bounds.size);
            foreach (Transform child in transform)
                child.localPosition = boundedArea.ClosestPoint(child.localPosition);
        }
    }


}