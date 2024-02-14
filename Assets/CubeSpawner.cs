// using Photon.Pun;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // 큐브 프리팹 연결을 위한 변수

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭 감지
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) // 레이캐스트가 평면에 닿았는지 확인
            {
                // PhotonNetwork.Instantiate(cubePrefab.name, hit.point, Quaternion.identity);
            }
        }
    }
}