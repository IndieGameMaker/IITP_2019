# 혁신성장 VR/AR 프로젝트 - 인천 글로벌 캠퍼스

## 수업 최종소스

- [최종소스 압축파일](https://1drv.ms/u/s!Asker0nVo1TS1dlW8GDXBVRmbWR9WA?e=WPd8Fq)

## 수업시 사용할 리소스

- [GearVR 슈팅게임 리소스1](https://1drv.ms/u/s!Asker0nVo1TS1oxoY4A-ApseuBkRXQ?e=6oeM5p)

- [GearVR 슈팅게임 리소스2](https://1drv.ms/u/s!Asker0nVo1TS1oxp1Zao5xauQi6ulw?e=4lKD1S)

- [VR/AR 리소스 압축파일](https://1drv.ms/u/s!Asker0nVo1TSyM8AZdw_r2Wt05-zgg?e=yZwd3B)

- [기어VR 텔리포트 패키지](https://developer.oculus.com/blog/teleport-curves-with-the-gear-vr-controller/)

- [Google VR SDK for Unity](https://github.com/googlevr/gvr-unity-sdk/releases)

- [Resonance Audio SDK for Unity](https://github.com/resonance-audio/resonance-audio-unity-sdk/releases)


# 모바일 VR 플랫폼

## Google VR for SDK

### 헤드 트래킹 에뮬레이터 구현
    - GvrEditorEmulator 프리팹

### 레티클 구현하기 - Google VR SDK를 이용해 구현한 경우
- GvrReticlePointer 프리팹 
- GvrPhysicPointerRaycaster 스크립트 -> MainCamera
- GvrEventSystem 프리팹

### 레티클 구현하기 - Unity 고유기능을 활용해 직접 구현한 경우
- Canvas 생성 및 Render Mode를 [World Space]
- 직접 Raycast를 투사해 객체를 선택

### VR용 UI 구현
- 메뉴 UI를 빌보드 처리
- 버튼 생성후 BoxCollider 처리
- 이벤트 생성해 전달하는 로직 (Eyecast)

## Daydream
- Daydream 컨트롤러 Input
- GvrInputDevices 스크립트

## Samsung GearVR
- Oculus Integeration을 에셋스토어에서 설치 (모바일용 Oculus SDK)
- CameraRig 프리팹
- GearVR 컨트롤러 프리팹
- OSIG 파일 생성 및 저장 (프로젝트 뷰의 "Plugins/Android/assets" 폴더로 OSIG 파일 저장)
- 개발자 모드 활성화 "GearVR Service" 앱 -> 저장공간 -> 저장공간 관리 -> 빌드번호 (6번 터치 후 활성화)
- 텔리포트 패키지(https://developer.oculus.com/blog/teleport-curves-with-the-gear-vr-controller/)

# AR 플랫폼

## Vuforia SDK
- 유니티에서 Vuforia 애드온 설치(유니티 허브에서 모듈추가)
- XR Settings 에서 Vuforia Argumented Supported 체크
- 뷰포리아 개발자 계정 등록 및 라이센스 발급
- 타겟메니저에 Image Target 등록 및 데이터베이스 다운로드
- Image 타겟 메뉴 (GameObject -> Vuforia Engine -> Image)
- Vuforia Scanner APK 설치 후 3D 스케닝후 Object Target 등록

## MAXST SDK
- 유니티 2018버전 설치
- MAXST 개발자 계정 등록 및 SDK 다운로드
- 라이센스 등록
- ARCamera 프리팹 , ImageTrackable 프리팹
- 스마트 글래스 설정 (ARCamera 선택 후 Configuration 버튼클릭 -> Optical See Through로 설정)

## ARCore SDK

## ARFoundation
