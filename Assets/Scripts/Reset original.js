var originalPosition : Vector3;
var originalRotation : Quaternion;

function Start() {
    originalPosition = transform.position;
    originalRotation = transform.rotation;
}

function Reset() {
    transform.position = originalPosition;
    transform.rotation = originalRotation;
}
