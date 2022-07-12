namespace UnityEngine.AI
{
    public class NavMeshObject : MonoBehaviour
    {
        private MeshFilter _meshFilter;
        private Color gizmoColor = new Color(1, 0.8915094f, 0.8915094f, 0.2627451f);

        private void OnDrawGizmos()
        {
            if (_meshFilter == null)
            {
                _meshFilter = GetComponent<MeshFilter>();
            }

            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            Vector3 lossyScale = transform.lossyScale;

            Gizmos.color = gizmoColor;
            if (_meshFilter == null) Gizmos.DrawSphere(transform.position, 2);
            else Gizmos.DrawMesh(_meshFilter.sharedMesh, position + Vector3.down * 0.1f, rotation, lossyScale);
        }
    }
}