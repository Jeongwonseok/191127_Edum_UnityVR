Edum (UnityVR)
======================

# 1. 개요
## 1.1. 게임 명
Education Music : 음악 교육

## 1.2. 장르
음악 교육 교구 (Unity VR)

## 1.3. 목적
Unity 엔진을 이용해서 1인칭 시점의 나라별 음악 교육 교구 제작

## 1.4. 게임 소개
```
- 현재 초등학교 교육에서 영상 위주의 체험형 교육을 진행 중이다.
- VR의 장점인 인터랙션과 몰입감을 이용해 보완할 수 있다.
- 피교육자는 악기 연주를 통해 능동적인 학습이 가능하다.
- 나라별 음악 교육 컨텐츠를 제작한다.
  (미국 - 재즈 , 한국 – 사물놀이)
```

## 1.5. 개발 범위
* **Scene**
```
* Intro
- 게임 시작, 조작법, 정보 기능을 포함하여 씬을 구성한다.

* USA
- 재즈의 기본적인 구성을 이루는 악기들의 정보에 대해 학습 가능하도록 씬을 구성한다.
  (피아노, 색소폰, 베이스, 드럼)
- 각 악기마다 3개의 샘플을 구성하고, 다양한 재즈 구성을 감상할 수 있도록 개발한다.

* Korea
- 사물놀이의 기본적인 구성을 이루는 악기들의 설명, 소리 듣기, 연주 기능을 포함하여 씬을 구성한다.
  (장구, 북, 꽹과리, 징)
- 장단 학습을 통해 3가지 장단의 설명 및 변화 느끼기 학습을 할 수 있도록 개발한다.
  (굿거리, 자진모리, 휘모리)
```

## 1.6. 개발 환경
* Unity 2019.2.9f1 Personal
* Visual Studio 2019
* 3ds Max 2020

## 1.7. 본인 역할
* 모델링 적용
* 프로그램 기획 참여
* 프로그램 개발 총괄 (Intro, USA, Korea 씬 개발)
 
****
# 2. 구조 설계
## 2.1. 클래스 구조도
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/클래스.png" width="700" height="350"><br>
</p>

* **Game Manager** : 게임에 대한 전체적인 흐름을 담당한다. (Scene, Fade In & out)
```
* Sound Manager
- 게임에 사용되는 모든 Sound를 보관하고, 출력하는 기능을 담당한다.

* Effect Manager
- 게임에서 버튼 클릭 시, 재생되는 효과음을 보관하고, 출력하는 기능을 담당한다.
```


* **OVR Player** : Oculus에서 제공하는 Player 컴포넌트와 관련된 C# 스크립트를 오버라이딩하여 기능을 제공한다.
```
* OVR Camera Rig
- Tracking Type 을 Floor Level로 변경한다.

* OVR Player Controller
- Player의 너비와 높이를 물리적인 공간에서 제약없이 수행되도록 설정한다.

* Hand Controller
- Collider 설정과, OVR Grabber 컴포넌트를 이용해 물건 잡기를 구현한다.
```


* **UI** : 화면에 표시 되어야 할 게임 정보 및 대화와 관련된 모든 정보를 출력하는 기능을 담당한다. 
```
* Game Status
- 게임의 현재 상태 정보를 제공한다.

* Game Info
- 각 씬의 설명, 게임 조작법, 악기 및 장단 설명을 제공한다.

* UI Helpers
- LaserPointer와 Sphere Collider를 이용해 버튼 클릭 기능을 제공한다. 
```


* **Item** : 게임 Item 고유의 특성 및 Tracking 기능을 정의한다.  
```
* Sound Item
- 3D 입체 음향 기법을 이용해 Audio Source 컴포넌트를 정의한다.

* Interactable Item
- 플레이어가 악기 채를 잡을 수 있고, 상호작용을 통해 악기 연주하기 기능을 정의한다.

* Non-Interactable Item
- 상호작용이 없는 물체들의 Collider 및 Rigidbody 설정을 통해 정의한다.
```

## 2.2. 씬 구조도
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/씬.png" width="800" height="300"><br>
</p>

* **설명**
```
* Intro : 게임 시작, 컨트롤러 조작법, 게임 정보 기능을 담당하는 씬이다.

* USA : 재즈 장르를 체험할 수 있다.
- 여러 상호작용을 통해 체험 가능하다.
  (피아노, 색소폰, 베이스, 드럼)

* Korea : 사물놀이 장르를 체험할 수 있다.
- 악기 학습 : 각 악기의 설명 및 샘플 소리 듣기, 연주하기 기능을 제공한다.
- 장단 학습 : 각 장단의 설명 및 샘플 소리 듣기 기능을 제공한다.
```

* **구성**
```
* Intro
- 시작 : 국가 선택 페이지를 제공한다.
- 조작법 : 컨트롤러 조작법에 대한 설명을 제공한다.
- 정보 : 게임에 관한 정보를 제공한다.

* USA
- 시작 : 간단한 게임 진행 설명을 제공하고, 게임을 실행한다.
- 조작법 : 컨트롤러 조작법에 대한 설명을 제공한다.
- 홈 : Intro 씬으로 되돌아간다.

* Korea
- 시작 : 간단한 게임 진행 설명을 제공하고, 게임을 실행한다.
- 조작법 : 컨트롤러 조작법에 대한 설명을 제공한다.
- 홈 : Intro 씬으로 되돌아간다.
```

****
# 3. 주요 구현부
## 3.1. Audio
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/audio1.png" width="300" height="200">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/audio2.png" width="300" height="500"><br>
</p>

```
* 설명
- 북의 자식 객체에 각각의 역할을 하는 Audio Source를 추가한다.
- Audio Source에 각 Clip을 미리 추가하고, Spatial Blend 옵션을 3D로 설정한다.
- 3D Sound Settings의 세부 설정을 통해 최소 및 최대 거리를 지정한다.
```

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/audio3.png" width="406" height="684">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/EDUM/audio4.png" width="450" height="546"><br>
</p>

```
* 설명
- 연주하기 기능 정의를 위해 Audio Source에 각 악기의 연주 사운드를 추가한다. 
- 악기마다 Collider를 각기 다르게 추가하고, Collider Script를 컴포넌트로 추가한다. 
```

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro2.png" width="500" height="500"><br>
</p>

```
* 설명
- 마지막 배열 인덱스가 아니라면, Next 버튼을 활성화한다. 
- contextCount 변수를 이용해 대화의 순서를 읽고, 각 순서에 출력할 Animation을 실행한다.
- 텍스트를 한 글자씩 딜레이를 주면서 출력하기 위해 Coroutine을 사용한다.
```

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro3.png" width="500" height="400"><br>
</p>

```
* 설명
- Next 버튼 클릭 시, 이전의 Sound를 중지하고, 모든 Bool 값을 false로 바꿔준다.
- Next 버튼 클릭 시, Text 내용을 잠시 없애준다.
- Next 버튼 클릭 시, 모든 UI 및 버튼을 잠시 비활성화한다.
- if 문을 통해 contextCount 변수를 업데이트 하고, 대사에 맞는 사운드를 재생한다.
- 이어서, Coroutine을 실행한다.
```

* **CountDownTimer()**<br>
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/coro4.png" width="600" height="500"><br>
</p>

```
* 설명
- 초 저장 변수를 선언하고, 초기화한다.
- TimeSpan 구조체를 이용해 분, 초 간격으로 나누고, 이를 Timer UI에 해당 텍스트를 저장한다.
- 초 저장 변수가 0이 되면, Game Over로 간주하고, GameOver() Coroutine을 실행한다.
- 5초의 여유시간을 주고, Intro 씬으로 전환한다.
```

## 3.2. ClosePos
* **ClosePhone()**
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/close.png" width="500" height="400"><br>
</p>

```
* 설명
- Vector3의 sqrMagnitude를 이용해 크기의 제곱 값을 저장한다.
- 이후, if문을 이용해 지정한 거리 범위의 제곱 값과 현재 거리의 제곱 값을 비교한다.
- 크기의 제곱 값을 비교하는 방법은 루트 연산을 하지 않기 때문에 연산 속도가 더 빠르므로 크기를 비교하는 것보다 더 효율적이다.
```

****
# 4. 참고
## 4.1. 참여 목록
* **2019 콘텐츠원캠퍼스 구축운영 및 VR 콘텐츠 개발 사업**<br>
    -입체 및 공간 음향을 활용한 방 탈출 게임(VR) 개발<br>
    [문화체육관광부, KOCCA(한국콘텐츠진흥원), 성결대학교 산학협력단, XRCENTER, 안양창조산업진흥원]<br>
    
* **학생주도 연구 프로그램 지원 사업**<br>
    -노력 정당화 이론 기반의 가상현실 콘텐츠 개발<br>
    [성결대학교 미래발전연구원]

## 4.2. 스크린 샷
<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/스크린1.png" width="800" height="300"><br>
</p>

<p align="center">
<img src="https://github.com/Jeongwonseok/Portfolio_JWS/blob/master/image/ABHD/스크린2.png" width="700" height="400"><br>
</p>

## 4.3. 참고 url
* 게임 플레이 영상 : <https://youtu.be/BGeL1tWlY9w/>
