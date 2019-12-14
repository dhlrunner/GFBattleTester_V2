function FindProxyForURL(url, host) {
  if (dnsDomainIs(host, "gf-game.girlfrontline.co.kr")) {
    return "PROXY 192.168.0.13:80";
  } 
  else {
    return "DIRECT";
  } 
}