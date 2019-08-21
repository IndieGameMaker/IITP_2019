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

# PROJECT 교육융합/국방융합

개발기간 : 2019/08/09 ~ 2019/08/22

**발표일 : 2019/08/23 16:00 ~ 18:00**

|팀|프로젝트 명|팀원|
|-|-|-|
|팀 1|조대프(조난 대피 훈련 프로젝트)|**이승민(팀장)**,이정민,문종혁|
|팀 2|내친구,반려식물|**권용택(팀장)**,박지연,강호준|
|팀 3|Skydiving Simulator|**박규태(팀장)**,한영준|
|팀 4|햇님달님|**박보령(팀장)**,백종욱,방희진|
|팀 5|Purify|**김현철(팀장)**,김지윤,박진수|

**중간점검 : 2019/08/16** 

발표순서 : 2019/08/22 확정

발표리허설 : 2019/08/23 10:00 ~ 12:00

## 팀 작업시 주의사항

### 소스 코드 형상관리(Source Backup)
팀장이 마스터 권한을 갖는 것을 원칙으로 합니다.

- 깃 허브
- 유니티 콜라보레이트
- 개인별로 일자별로 압축파일을 생성해 백업한다.

### 코딩 규약(Coding Standard)
- 유니티는 동일한 버전으로 개발한다. (ex. Unity 2019.1.13f)
- Tag 명, Layer 명의 대소문자 규약을 팀원과 협의해 결정한다.
- 프로젝트 폴더명은 모두 통일한 후 작업하며 추가해야 할 경우 마스터 권한자가 생성한다.
- 변수명명 규칙, 함수(메소드) 명명 규칙을 정한다. Microsoft에서 제공하는 표준안을 따르는 것을 원칙으로 한다. 
    - [C# Study 변수명명법](http://www.csharpstudy.com/Guide/Guide-naming.aspx)
    - [MS 코딩 표준안](https://docs.microsoft.com/ko-kr/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

### 리소스(에셋 스토어) 구매 가이드
- 메디치 계정의 에셋 스토어에서 찾고자 하는 에셋을 먼저 검색한다.
- 구매 가능한 구매 에셋은 3D 모델, 2D 텍스처(UI 포함), 사운드, 이펙트에 한정함.
- 가급적 로우 폴리 모델을 선택한다.(Vive 제외)
- LOD 적용된 모델을 우선한다.

## 최종 발표 준비 및 일정
### 가산 발표회 참조 링크
[가산 발표회 발표자료](https://docs.google.com/presentation/d/1Wi4CPOxZsDX_MSDc5-Cf3IT8eme0nka0bkgZK7LOFsM/edit#slide=id.g5df383f5be_5_66)

### 발표자료 구글 문서
[발표문서 구글링크](https://docs.google.com/presentation/d/1xkjsEPpNUXvr5I4SFbCv2s6nHFZQSIDbWUe_DkwHEK4/edit#slide=id.p)

### 일정
21일 
- 오후 부터 발표문서 작성 시작
- 팀별 문서작업자 선정

22일 
- 발표자료에 첨부할 시연 동영상 촬영 시작

23일 
- 10:00 ~ 12:00 팀별 **리허설**
- 12:00 ~ **소스코드 변경금지**
- 16:00 ~ 18:00 **프로젝트 발표회**
