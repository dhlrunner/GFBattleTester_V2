function FindProxyForURL(url, host) {
  if (dnsDomainIs(host, "gf-game.girlfrontline.co.kr")) {
    return "PROXY 192.168.0.13:80";
  } 
  else if (dnsDomainIs(host, "gfkrcdn.imtxwy.com")) {
    return "PROXY 192.168.0.13:80";
  }
  else {
    return "DIRECT";
  } 
}