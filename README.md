# GFBattleTester_V2
 a simple battle packet simulater for GFKR client
 
 new project from GFBattleTester(https://github.com/dhlrunner/GFBattleTester). 
 
 old project has been discontinued. will be archived soon.

## Quick Setup
- Run the program
- Go to サーバ設定
- Set your local IP address in IP textbox, and set your port in Port textbox
- Go to /data/db/pac forder and open pac.js
- Edit Line3 `return "PROXY 192.168.0.13:80";` to `return "PROXY YOUR_IP_ADDR:YOUR_PORT_NUM";` and save file
- Click Start Server button
- Go to your GFKR platform
- open PAC settings
- enter the PAC url to http://YOUR_IP_ADDR:YOUR_PORT_NUM/getpac/pac.js and save
- Run the GFKR client
- if 送信,受信 indicator is blinking, that means your GFKR clients communicating GFBattleTester succesfly
