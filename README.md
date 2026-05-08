# 2D-Delivery-Game
Unity 기반으로 제작한 2D 배달 게임 프로젝트입니다.  플레이어는 차량을 조작하여 패키지를 수집하고 목적지까지 배달합니다.

---

# 프로젝트 목표

- Unity 2D 물리 시스템 이해
- Trigger / Collision 이벤트 학습
- 상태 기반 게임 로직 구현
- 카메라 추적 시스템 구현
- C# 스크립트 구조 학습

---

# 개발 환경

- Unity 6
- C#
- Visual Studio

---

# 주요 기능

## 차량 이동 시스템
- Input 기반 차량 조작
- 회전 및 이동 처리
- 충돌 시 속도 감소
- 부스터 획득 시 속도 증가

## 카메라 추적 시스템
- 플레이어 위치 기반 카메라 추적
- LateUpdate를 사용하여 부드러운 카메라 이동 구현

## 배달 시스템
- 패키지 획득 기능
- 배달 상태 관리
- 배달 상태에 따른 플레이어 색상 변경

---

# 사용 기술

- Rigidbody2D
- Trigger / Collision
- SerializeField
- LateUpdate
- Component Reference
- State Management

---


# 스크린 샷
<img width="1114" height="401" alt="스크린샷(754)" src="https://github.com/user-attachments/assets/68b8576b-4321-413f-a342-f33f1f7ad3f3" />



# 트러블 슈팅

## Trigger와 Collision 차이

처음에는 모든 충돌 처리를 Collision으로 구현했지만,
패키지 획득과 같은 관통 가능한 오브젝트는 Trigger가 더 적절하다는 점을 학습했습니다.

## 카메라 흔들림 문제

카메라를 Update에서 추적할 경우 플레이어 이동과 갱신 타이밍 차이로 흔들림이 발생했습니다.

이를 LateUpdate로 변경하여 플레이어 이동 이후 카메라가 갱신되도록 수정했습니다.

---

# 개선 예정 사항

- UI 시스템 추가
- 점수 시스템 구현
- 사운드 추가
- Object Pooling 적용
- ScriptableObject 기반 데이터 관리
