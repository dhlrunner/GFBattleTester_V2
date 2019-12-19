# GFBattleTester_V2
 a simple battle packet simulater for GFKR client
 
 new project from GFBattleTester(https://github.com/dhlrunner/GFBattleTester). 
 
 old project has been discontinued. will be archived soon.
## English
### Quick Setup
- Run the program
- Go to サーバ設定
- Set your local IP address in IP textbox, and set your port in Port textbox
- Go to /data/db/pac folder and open pac.js
- Edit Line3 `return "PROXY 192.168.0.13:80";` to `return "PROXY YOUR_IP_ADDR:YOUR_PORT_NUM";` and save file
- Click Start Server button
- Go to your GFKR platform
- open PAC settings
- enter the PAC URL to `http://YOUR_IP_ADDR:YOUR_PORT_NUM/getpac/pac.js` and save
- Run the GFKR client
- if 送信,受信 indicator is blinking, that means your GFKR clients communicating GFBattleTester successfully

### Currently...
- Japanese UI
- Not supporting battle simulating yet
- UI is incompleted
- maybe have an unexpected errors
- Console debugging enabled

### Anyone Can Help ME?
- i cannot decrypt a gfl's gun stats data(it known as cachedata.dat or stc_data.dat files), so im currently using `https://github.com/umang-p/brainlets/blob/master/brainlets/girlsfrontline/static/girlsfrontline/dolls.json` 's data. it is missing some guns data (9000~9045 guns and MODded guns). so i want to decrypt it and make a my own guns db and use a my programs. anyone can help me? im waiting a reply who can decrypt a cachedata.

## 日本語
### クイックセットアップ
- GFBattleTesterを実行します。
- サーバ設定タブをクリックします
- IPテキストボックスにローカルIPアドレスを入力し、ポートテキストボックスにポートを入力します。
- /data/db/pac フォルダーに移動し、pac.jsファイルをテキストエディタで開きます。
- 3行目 `return "PROXY 192.168.0.13:80";` を `return "設定したIPアドレス:設定したポート番号";` に書き換え、保存します。
- Start Server ボタンをクリックします。
- ドルフロKRクライアントが実行されているプラットフォームに戻ります。
- PAC設定を開きます。
- PAC設定URL欄に`http://設定したIPアドレス:設定したポート番号/getpac/pac.js`を入力し、保存します。
- ドルフロKRクライアントを実行します。
- 送信、受信インジケータが点滅している場合、ドルフロKRクライアントがGFBattleTesterを正常に通信していることを意味します。

### 現状
- 日本語UI
- まだ戦闘シミュレートはサポートしていません。
- UIは不完全です。
- 予期しないエラーが発生する可能性があります。
- 基本にコンソールウィンドウが表示されます。

### これについて知っている方、いらっしゃいますか？
- ドルフロの人形能力値データ（cachedata.datまたはstc_data.datファイルとして知られている）を復号化できなかったため、現在、 `https：//github.com/umang-p/brainlets/blob/master/brainlets/girlsfrontline/static/girlsfrontline/dolls.json`のデータを使用しています。これにはいくつかの人形データが欠落しています（9000番帯の人形データおよび改造データ）。 このプログラムの情報をもっと豊かにするため、cachedata.dat ファイルの中身が必要です。もしこれを複合化出来る方で、その方法を教えてくれる方がいらっしゃいましたら、ぜひども、下記の連絡先まで連絡お願い致します。

## 한국어

### 빠른 시작 가이드
- 프로그램을 실행시킵니다.
- サーバ設定 탭을 클릭합니다.
- IP 텍스트 상자에 로컬 IP 주소를 입력하고, 포트 텍스트 상자에 포트를 입력해 주세요.
- /data/db/pac 폴더로 이동하여 pac.js 파일을 텍스트 에디터로 엽니다.
- 3번째 줄 `return "PROXY 192.168.0.13:80";` 을 `return "설정한_IP_주소:설정한_포트_번호";` 로 바꾼 뒤 저장합니다.
- Start Server 버튼을 클릭합니다.
- 소전 한섭이 실행되고 있는(또는 실행될) 플렛폼으로 이동합니다.
- PAC 설정을 엽니다.
- PAC URL 입력란에 `http://설정한_IP_주소:설정한_포트_번호/getpac/pac.js` 를 입력하고 저장합니다.
- 한섭 클라이언트를 실행합니다.
- 送信,受信 인디케이터가 깜빡이면 한섭 클라이언트와 시뮬레이터의 통신이 성공했음을 의미합니다.

### 현제....
- 일본어 UI
- 아직 전투 시뮬레이터 기능이 없습니다.
- UI가 불완전합니다.
- 예상치 못한 에러가 발생할 수 있습니다.
- 프로그램 실행 시 콘솔도 같이 열립니다. 프로젝트 설정에서 비활성화 할 수 있습니다.

### 도움을 구합니다..
- 소녀전선 클라이언트의 인형 능력치 데이터 (cachedata.dat 또는 stc_data.dat 파일로)를 복호화할수 없기 때문에 현재`https://github.com/umang-p/brainlets/blob/master/brainlets/girlsfrontline/static/girlsfrontline/dolls.json`의 데이터를 사용하고 있습니다. 여기에는 몇 가지 인형 데이터가 누락되어 있습니다 (9000번대 인형 데이터 및 개조된 인형 정보). 이 프로그램의 기능을 더 풍부하게 하기 위해 cachedata.dat 파일의 내용이 필요합니다. 만약 이 파일을 복호화 할 수 있는 분들 중, 그 방법을 가르쳐 주실분이 계신다면, 부디, 아래의 연락처로 연락 부탁드립니다. 감사합니다.


## Contects
- dhlrunner@gmail.com
- @dhlrunner (Twitter)
- runner38#4862 (discord)
